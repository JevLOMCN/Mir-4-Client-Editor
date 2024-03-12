using System.Diagnostics;

namespace Mir_4_Client_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Export
        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "PAK files (*.pak)|*.pak",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Jev - Placeholer
                    string selectedFilePath = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open PAK file. Original error: " + ex.Message);
                }
            }
        }
        #endregion

        #region Edit Export
        private void EditExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog
            {
                Description = "Select Export folder",
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Jev - Placeholer
                    string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open Export folder. Original error: " + ex.Message);
                }
            }
        }
        #endregion

        #region RePak
        private void rePakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog
            {
                Description = "Select folder to RePak",
                ShowNewFolderButton = true
            };

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Jev - Placeholder
                    string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not select folder for RePak. Original error: " + ex.Message);
                }
            }
        }
        #endregion
    }
}
