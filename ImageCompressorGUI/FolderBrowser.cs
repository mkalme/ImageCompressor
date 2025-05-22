using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using ImageCompressor;
using CustomDialogs;

namespace ImageCompressorGUI {
    public partial class FolderBrowser : Form {
        private HashSet<string> _folders = new HashSet<string>();

        public FolderBrowser(IEnumerable<string> folders = null) {
            InitializeComponent();

            if (folders != null) {
                _folders.UnionWith(folders);
            }

            LoadGridView();
        }

        //Update
        private void LoadGridView() {
            GridView.Rows.Clear();

            foreach (var folder in _folders) {
                GridView.Rows.Add(folder);

                DataGridViewRow row = GridView.Rows[GridView.Rows.Count - 1];
                row.Tag = folder;
            }
        }

        private void FolderBrowser_Load(object sender, EventArgs e) {
            GridView.ClearSelection();
        }

        //DragDrop
        private void FolderBrowser_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void FolderBrowser_DragDrop(object sender, DragEventArgs e) {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);
            _folders.UnionWith(folders);

            LoadGridView();
        }

        private void AddFolderButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();

            _folders.Add(FolderBrowserDialog.SelectedPath);
            LoadGridView();
        }

        private void RemoveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            HashSet<string> folders = new HashSet<string>();
            
            foreach (DataGridViewRow row in GridView.SelectedRows) {
                folders.Add(row.Tag as string);
            }

            foreach (var folder in folders) {
                RemoveRow(folder);
                _folders.Remove(folder);
            }
        }
        private void RemoveRow(string folder) {
            for (int i = 0; i < GridView.Rows.Count; i++) {
                if ((string)GridView.Rows[i].Tag == folder) {
                    GridView.Rows.RemoveAt(i);
                    return;
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }
        private void CompressButton_Click(object sender, EventArgs e) {
            Compressor compressor = new Compressor() { 
                Level = (long)LevelUpDown.Value
            };

            FolderCompressor folderCompressor = new FolderCompressor() { 
                Compressor = compressor
            };

            folderCompressor.Compress(_folders.ToArray(), PathTextBox.Text);

            CustomDialog.ShowMessage("Done", "Compression has been completed.");
        }
    }
}
