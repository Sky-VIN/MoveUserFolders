using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;



namespace MUF
{
    public partial class MainForm : Form
    {
        private bool modify = false;

        private List<string[]> folders = new List<string[]>();
        private List<string> newFolders = new List<string>();


        public MainForm()
        {
            InitializeComponent();

            /* making app size smaller by icon size */
            Icon = Resources.MainIcon;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            folders.Clear();
            newFolders.Clear();

            /* filling main list */
            folders.Add(MUFRegistry.GetFolderValue(MUFRegistry.FolderKeys.DESKTOP));
            folders.Add(MUFRegistry.GetFolderValue(MUFRegistry.FolderKeys.DOCS));
            folders.Add(MUFRegistry.GetFolderValue(MUFRegistry.FolderKeys.VIDEOS));
            folders.Add(MUFRegistry.GetFolderValue(MUFRegistry.FolderKeys.MUSIC));
            folders.Add(MUFRegistry.GetFolderValue(MUFRegistry.FolderKeys.PICTURES));
            folders.Add(MUFRegistry.GetFolderValue(MUFRegistry.FolderKeys.DOWNLOADS));

            /* filling secondary list from main list */
            foreach (string[] folder in folders)
                newFolders.Add(folder[1]);
            
            cbFoldersList.SelectedIndex = 0;
            cbFoldersList.Focus();
        }

        /* message if there are changes */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modify)
                MessageBox.Show(Resources.ModifyMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /* Changing elemnts depending list */
        private void cbFoldersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoldersList.SelectedIndex == 0) folderImg.BackgroundImage = Resources.DesktopImage;
            if (cbFoldersList.SelectedIndex == 1) folderImg.BackgroundImage = Resources.DocsImage;
            if (cbFoldersList.SelectedIndex == 2) folderImg.BackgroundImage = Resources.VideosImage;
            if (cbFoldersList.SelectedIndex == 3) folderImg.BackgroundImage = Resources.MusicImage;
            if (cbFoldersList.SelectedIndex == 4) folderImg.BackgroundImage = Resources.PicturesImage;
            if (cbFoldersList.SelectedIndex == 5) folderImg.BackgroundImage = Resources.DownloadsImage;

            txtTarget.Text = newFolders[cbFoldersList.SelectedIndex];
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (fbDialog.ShowDialog() == DialogResult.OK)
                txtTarget.Text = fbDialog.SelectedPath;
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (DirectoryExists())
                Process.Start("explorer.exe", txtTarget.Text);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            /* remember last list index */
            int lastIndex = cbFoldersList.SelectedIndex;

            /* refresh */
            MainForm_Load(sender, e);

             /* return last list index */
            cbFoldersList.SelectedIndex = lastIndex;
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            /* if directory exists */
            if (DirectoryExists())
            {
                /* if directory writable */
                string result = DirectoryWritable();
                if (result == null)
                {
                    new Move(
                        folders[cbFoldersList.SelectedIndex][0],
                        folders[cbFoldersList.SelectedIndex][1],
                        txtTarget.Text, chbContent.Checked);

                    /* refresh */
                    btnRefresh_Click(sender, e);
                    
                    modify = true;
                }
                else
                    MessageBox.Show(result, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtTarget_TextChanged(object sender, EventArgs e)
        {
            newFolders[cbFoldersList.SelectedIndex] = txtTarget.Text;
            btnApply.Enabled = CheckSimilarity(folders[cbFoldersList.SelectedIndex][1], txtTarget.Text);
        }


        private bool CheckSimilarity(string source, string target)
        { return !source.Equals(target); }


        private bool DirectoryExists()
        {
            if (Directory.Exists(txtTarget.Text)) return true;
            else MessageBox.Show(Resources.FolderNotFound, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtTarget.SelectAll();
            txtTarget.Focus();

            return false;
        }


        private string DirectoryWritable()
        {
            try
            {
                File.Create(txtTarget.Text + "\\check").Close();
                File.Delete(txtTarget.Text + "\\check");
            }
            catch (Exception e)
            { return e.Message; }

            return null;
        }
    }
}
