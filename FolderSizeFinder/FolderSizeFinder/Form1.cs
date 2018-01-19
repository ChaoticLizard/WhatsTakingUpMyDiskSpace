using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolderSizeFinder
{
    public partial class Form1 : Form
    {
        List<DriveInfo> allActiveDrives = new List<DriveInfo>();    // DriveInfo object and name
        enum dirFilters {
            Hidden = 0,
            System,
            ReadOnly
        };
        long minMB = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        //
        // Scan computer for all drives on the system and populate within listbox
        //
        private void InitializeData()
        {
            this.checkedListBoxDrives.DataSource = this.GetAvailableDrives();
        }

        private List<string> GetAvailableDrives()
        {
            List<string> results = new List<string>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach ( DriveInfo d in allDrives )
            {
                if ( d.IsReady )
                {
                    results.Add( d.Name + " (" + d.VolumeLabel + ")");
                    allActiveDrives.Add( d );
                }
            }
            return results;
        }

        //
        // for each selected drive, scan the file system and output the size of each directory
        //
        private void buttonScan_Click( object sender, EventArgs e )
        {
            // clear any existing content in the datagrid
            dataGridViewFolderResults.Rows.Clear();

            // set the min size threshold
            try
            {
                minMB = Convert.ToInt64(comboBoxMinMB.Text);
            }

            catch (System.FormatException)
            {
                // if invalid input or nothing is in the box, then default to 0MB
                minMB = 0;
            }
            // retreive which drives to scan (use checked indices to make drive list since list is not rearranged
            List<DirectoryInfo> drivesToScan = new List<DirectoryInfo>();
            foreach ( int driveIndex in this.checkedListBoxDrives.SelectedIndices )
            {
                // interate all the directories and collect the sum of files sizes
                DriveInfo drive = allActiveDrives[driveIndex];

                // for each directory sum the size of all the files
                DirectoryInfo dir = drive.RootDirectory;

                recurseDirectories( dir );
            }
        }


        //
        // recursively get directory size and populate the size datagrid
        //
        private void recurseDirectories( DirectoryInfo dir )
        {
            long size = DirectorySize( dir );
            size = size / 1000000;  // convert to MB

            // populate the size data grid.
            if ( size > minMB )
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells( dataGridViewFolderResults );
                newRow.Cells[0].Value = dir.FullName;
                newRow.Cells[1].Value = size;
                dataGridViewFolderResults.Rows.Add( newRow );
            }

            // now do for all dir children
            try
            {
                foreach ( DirectoryInfo d in dir.EnumerateDirectories() )
                {
                    // TODO: Add filtering of directories here
                    recurseDirectories( d );
                }
            }
            catch ( System.UnauthorizedAccessException )
            {
                // no access to that folder so skip
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                // cannot find part of the path so skip
            }
        }

        //
        // returns the size of the directory
        //
        private long DirectorySize( DirectoryInfo dir )
        {
            long size = 0;
            try
            {
                foreach ( FileInfo f in dir.EnumerateFiles() )
                {
                    if ( f.Attributes != FileAttributes.Directory )
                    {
                        size += f.Length;
                    }
                }
            }
            catch ( System.UnauthorizedAccessException )
            {
                // no access to that folder so will give a size of -1
                size = -1;
            }
            catch ( System.IO.DirectoryNotFoundException )
            {
                // Cannot find "part of the path", so will give a size of -1
                size = -1;
            }
            return size;
        }
    }
}
