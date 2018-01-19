namespace FolderSizeFinder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxDrives = new System.Windows.Forms.CheckedListBox();
            this.labelDrive = new System.Windows.Forms.Label();
            this.buttonScan = new System.Windows.Forms.Button();
            this.dataGridViewFolderResults = new System.Windows.Forms.DataGridView();
            this.Folder = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBoxDirFilter = new System.Windows.Forms.CheckedListBox();
            this.labelDirFilter = new System.Windows.Forms.Label();
            this.comboBoxMinMB = new System.Windows.Forms.ComboBox();
            this.labelMinMB = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFolderResults)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxDrives
            // 
            this.checkedListBoxDrives.CheckOnClick = true;
            this.checkedListBoxDrives.FormattingEnabled = true;
            this.checkedListBoxDrives.Location = new System.Drawing.Point(49, 34);
            this.checkedListBoxDrives.Name = "checkedListBoxDrives";
            this.checkedListBoxDrives.Size = new System.Drawing.Size(160, 94);
            this.checkedListBoxDrives.TabIndex = 0;
            // 
            // labelDrive
            // 
            this.labelDrive.AutoSize = true;
            this.labelDrive.Location = new System.Drawing.Point(49, 15);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(139, 13);
            this.labelDrive.TabIndex = 1;
            this.labelDrive.Text = "Select which Drives to scan";
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(52, 466);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // dataGridViewFolderResults
            // 
            this.dataGridViewFolderResults.AllowUserToOrderColumns = true;
            this.dataGridViewFolderResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFolderResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folder,
            this.Size});
            this.dataGridViewFolderResults.Location = new System.Drawing.Point(215, 34);
            this.dataGridViewFolderResults.MultiSelect = false;
            this.dataGridViewFolderResults.Name = "dataGridViewFolderResults";
            this.dataGridViewFolderResults.RowHeadersWidth = 25;
            this.dataGridViewFolderResults.Size = new System.Drawing.Size(603, 762);
            this.dataGridViewFolderResults.TabIndex = 3;
            // 
            // Folder
            // 
            this.Folder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Folder.HeaderText = "Folder";
            this.Folder.Name = "Folder";
            this.Folder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Folder.Width = 61;
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Size.HeaderText = "Size (MB)";
            this.Size.Name = "Size";
            this.Size.Width = 77;
            // 
            // checkedListBoxDirFilter
            // 
            this.checkedListBoxDirFilter.FormattingEnabled = true;
            this.checkedListBoxDirFilter.Items.AddRange(new object[] {
            "Hidden",
            "System",
            "Read-Only"});
            this.checkedListBoxDirFilter.Location = new System.Drawing.Point(52, 256);
            this.checkedListBoxDirFilter.Name = "checkedListBoxDirFilter";
            this.checkedListBoxDirFilter.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxDirFilter.TabIndex = 4;
            // 
            // labelDirFilter
            // 
            this.labelDirFilter.AutoSize = true;
            this.labelDirFilter.Location = new System.Drawing.Point(52, 237);
            this.labelDirFilter.Name = "labelDirFilter";
            this.labelDirFilter.Size = new System.Drawing.Size(137, 13);
            this.labelDirFilter.TabIndex = 5;
            this.labelDirFilter.Text = "Types to exclude from scan";
            // 
            // comboBoxMinMB
            // 
            this.comboBoxMinMB.FormattingEnabled = true;
            this.comboBoxMinMB.Items.AddRange(new object[] {
            "100",
            "1000",
            "10000"});
            this.comboBoxMinMB.Location = new System.Drawing.Point(55, 185);
            this.comboBoxMinMB.Name = "comboBoxMinMB";
            this.comboBoxMinMB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMinMB.TabIndex = 6;
            // 
            // labelMinMB
            // 
            this.labelMinMB.AllowDrop = true;
            this.labelMinMB.AutoSize = true;
            this.labelMinMB.Location = new System.Drawing.Point(52, 166);
            this.labelMinMB.Name = "labelMinMB";
            this.labelMinMB.Size = new System.Drawing.Size(94, 13);
            this.labelMinMB.TabIndex = 7;
            this.labelMinMB.Text = "Only show > X MB";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 514);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 846);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelMinMB);
            this.Controls.Add(this.comboBoxMinMB);
            this.Controls.Add(this.labelDirFilter);
            this.Controls.Add(this.checkedListBoxDirFilter);
            this.Controls.Add(this.dataGridViewFolderResults);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.labelDrive);
            this.Controls.Add(this.checkedListBoxDrives);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFolderResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxDrives;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.DataGridView dataGridViewFolderResults;
        private System.Windows.Forms.CheckedListBox checkedListBoxDirFilter;
        private System.Windows.Forms.Label labelDirFilter;
        private System.Windows.Forms.DataGridViewLinkColumn Folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.ComboBox comboBoxMinMB;
        private System.Windows.Forms.Label labelMinMB;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

