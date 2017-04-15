using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Move_User_Folders
{
    public partial class MainForm : Form
    {
        private string path;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Чтение значений из реестра и присваивание их элементам
            Reg reg = new Reg();
            lDesktop.Text = reg.GetItem("Desktop");
            lDownloads.Text = reg.GetItem("{374DE290-123F-4565-9164-39C4925E467B}");
            lPersonal.Text = reg.GetItem("Personal");
            lVideo.Text = reg.GetItem("My Video");
            lMusic.Text = reg.GetItem("My Music");
            lPictures.Text = reg.GetItem("My Pictures");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            // Назачение последней выбраной папки
            fbDialog.SelectedPath = path;

            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                // Запись в переменную последней выбраной папки
                path = fbDialog.SelectedPath;

                // Какая кнопка была нажата, тужа и пишем выбраную папку (switch сделать не смог)
                if (sender == btnOpenDesktop) tbDesktop.Text = path;
                else if (sender == btnOpenDownloads) tbDownloads.Text = path;
                else if (sender == btnOpenPersonal) tbPersonal.Text = path;
                else if (sender == btnOpenVideo) tbVideo.Text = path;
                else if (sender == btnOpenMusic) tbMusic.Text = path;
                else if (sender == btnOpenPictures) tbPictures.Text = path;
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            // Какая кнопка была нажата, с теми параметрами и вызываю метод перемещения
            if (sender == btnSetDesktop)
            {
                if (DirExists(tbDesktop.Text) && DirExists(lDesktop.Text))
                    new Move("Desktop", lDesktop.Text, tbDesktop.Text);
            }

            else if (sender == btnSetDownloads)
            {
                if (DirExists(tbDownloads.Text) && DirExists(lDownloads.Text))
                    new Move("{374DE290-123F-4565-9164-39C4925E467B}", lDownloads.Text, tbDownloads.Text);
            }

            else if (sender == btnSetPersonal)
            {
                if (DirExists(tbPersonal.Text) && DirExists(lPersonal.Text))
                    new Move("Personal", lPersonal.Text, tbPersonal.Text);
            }

            else if (sender == btnSetVideo)
            {
                if (DirExists(tbVideo.Text) && DirExists(lVideo.Text))
                    new Move("My Video", lVideo.Text, tbVideo.Text);
            }

            else if (sender == btnSetMusic)
            {
                if (DirExists(tbMusic.Text) && DirExists(lMusic.Text))
                    new Move("My Music", lMusic.Text, tbMusic.Text);
            }

            else if (sender == btnSetPictures)
            {
                if (DirExists(tbPictures.Text) && DirExists(lPictures.Text))
                    new Move("My Pictures", lPictures.Text, tbPictures.Text);
            }

            // Обновление после перемещения
            Form1_Load(sender, e);
        }

        // Проверка на пустоту строки 
        private void OnTextChanged(object sender, EventArgs e)
        {
            if (sender == tbDesktop)
                if (tbDesktop.Text.Equals(""))
                    btnSetDesktop.Enabled = false;
                else btnSetDesktop.Enabled = true;

            else if (sender == tbDownloads)
                if (tbDownloads.Text.Equals(""))
                    btnSetDownloads.Enabled = false;
                else btnSetDownloads.Enabled = true;

            else if (sender == tbPersonal)
                if (tbPersonal.Text.Equals(""))
                    btnSetPersonal.Enabled = false;
                else btnSetPersonal.Enabled = true;

            else if (sender == tbVideo)
                if (tbVideo.Text.Equals(""))
                    btnSetVideo.Enabled = false;
                else btnSetVideo.Enabled = true;

            else if (sender == tbMusic)
                if (tbMusic.Text.Equals(""))
                    btnSetMusic.Enabled = false;
                else btnSetMusic.Enabled = true;

            else if (sender == tbPictures)
                if (tbPictures.Text.Equals(""))
                    btnSetPictures.Enabled = false;
                else btnSetPictures.Enabled = true;
        }

        // Проверка наличия папки
        private bool DirExists(string dir)
        {
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Folder \"" + dir + "\" doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
    }
}
