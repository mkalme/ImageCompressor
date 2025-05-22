
namespace ImageCompressorGUI {
    partial class FolderBrowser {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderBrowser));
            this.GridView = new CustomDialogs.DarkDataGridView();
            this.FolderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompressButton = new CustomDialogs.DarkButton();
            this.PathTextBox = new CustomDialogs.DarkTextBox();
            this.OutputDirectoryLabel = new CustomDialogs.DarkLabel();
            this.BrowseButton = new CustomDialogs.DarkButton();
            this.RemoveLink = new System.Windows.Forms.LinkLabel();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.AddFolderButton = new CustomDialogs.DarkButton();
            this.LevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.CompressionLebelLabel = new CustomDialogs.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolderCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.RowTemplate.Height = 25;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(456, 153);
            this.GridView.TabIndex = 0;
            // 
            // FolderCol
            // 
            this.FolderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FolderCol.HeaderText = "Folders";
            this.FolderCol.Name = "FolderCol";
            this.FolderCol.ReadOnly = true;
            // 
            // CompressButton
            // 
            this.CompressButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CompressButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CompressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompressButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompressButton.Location = new System.Drawing.Point(12, 278);
            this.CompressButton.Margin = new System.Windows.Forms.Padding(0);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(75, 24);
            this.CompressButton.TabIndex = 1;
            this.CompressButton.Text = "Compress";
            this.CompressButton.UseVisualStyleBackColor = true;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(97, 237);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.PathTextBox.PasswordChar = '\0';
            this.PathTextBox.ReadOnly = false;
            this.PathTextBox.Size = new System.Drawing.Size(371, 24);
            this.PathTextBox.TabIndex = 2;
            this.PathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.XOffset = 0;
            this.PathTextBox.YOffset = 0;
            // 
            // OutputDirectoryLabel
            // 
            this.OutputDirectoryLabel.AutoSize = true;
            this.OutputDirectoryLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OutputDirectoryLabel.Location = new System.Drawing.Point(8, 218);
            this.OutputDirectoryLabel.Name = "OutputDirectoryLabel";
            this.OutputDirectoryLabel.Size = new System.Drawing.Size(172, 15);
            this.OutputDirectoryLabel.TabIndex = 3;
            this.OutputDirectoryLabel.Text = "Browse for the output directory";
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Location = new System.Drawing.Point(12, 237);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 24);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RemoveLink
            // 
            this.RemoveLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.RemoveLink.AutoSize = true;
            this.RemoveLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveLink.Location = new System.Drawing.Point(418, 168);
            this.RemoveLink.Name = "RemoveLink";
            this.RemoveLink.Size = new System.Drawing.Size(50, 15);
            this.RemoveLink.TabIndex = 5;
            this.RemoveLink.TabStop = true;
            this.RemoveLink.Text = "Remove";
            this.RemoveLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveLink_LinkClicked);
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddFolderButton.Location = new System.Drawing.Point(12, 168);
            this.AddFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(91, 24);
            this.AddFolderButton.TabIndex = 6;
            this.AddFolderButton.Text = "Add folder";
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // LevelUpDown
            // 
            this.LevelUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LevelUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LevelUpDown.Location = new System.Drawing.Point(386, 281);
            this.LevelUpDown.Name = "LevelUpDown";
            this.LevelUpDown.Size = new System.Drawing.Size(82, 23);
            this.LevelUpDown.TabIndex = 7;
            this.LevelUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CompressionLebelLabel
            // 
            this.CompressionLebelLabel.AutoSize = true;
            this.CompressionLebelLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompressionLebelLabel.Location = new System.Drawing.Point(277, 284);
            this.CompressionLebelLabel.Name = "CompressionLebelLabel";
            this.CompressionLebelLabel.Size = new System.Drawing.Size(104, 15);
            this.CompressionLebelLabel.TabIndex = 8;
            this.CompressionLebelLabel.Text = "Compression level";
            // 
            // FolderBrowser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(480, 316);
            this.Controls.Add(this.CompressionLebelLabel);
            this.Controls.Add(this.LevelUpDown);
            this.Controls.Add(this.AddFolderButton);
            this.Controls.Add(this.RemoveLink);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.OutputDirectoryLabel);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.GridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FolderBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Compressor";
            this.Load += new System.EventHandler(this.FolderBrowser_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FolderBrowser_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FolderBrowser_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkDataGridView GridView;
        private CustomDialogs.DarkButton CompressButton;
        private CustomDialogs.DarkTextBox PathTextBox;
        private CustomDialogs.DarkLabel OutputDirectoryLabel;
        private CustomDialogs.DarkButton BrowseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderCol;
        private System.Windows.Forms.LinkLabel RemoveLink;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private CustomDialogs.DarkButton AddFolderButton;
        private System.Windows.Forms.NumericUpDown LevelUpDown;
        private CustomDialogs.DarkLabel CompressionLebelLabel;
    }
}

