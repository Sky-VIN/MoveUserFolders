namespace Move_User_Folders
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenPersonal = new System.Windows.Forms.Button();
            this.btnSetPersonal = new System.Windows.Forms.Button();
            this.tbPersonal = new System.Windows.Forms.TextBox();
            this.lPersonal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenDesktop = new System.Windows.Forms.Button();
            this.btnSetDesktop = new System.Windows.Forms.Button();
            this.tbDesktop = new System.Windows.Forms.TextBox();
            this.lDesktop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.btnSetVideo = new System.Windows.Forms.Button();
            this.tbVideo = new System.Windows.Forms.TextBox();
            this.lVideo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOpenMusic = new System.Windows.Forms.Button();
            this.btnSetMusic = new System.Windows.Forms.Button();
            this.tbMusic = new System.Windows.Forms.TextBox();
            this.lMusic = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnOpenPictures = new System.Windows.Forms.Button();
            this.btnSetPictures = new System.Windows.Forms.Button();
            this.tbPictures = new System.Windows.Forms.TextBox();
            this.lPictures = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelAbout = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnOpenDownloads = new System.Windows.Forms.Button();
            this.btnSetDownloads = new System.Windows.Forms.Button();
            this.tbDownloads = new System.Windows.Forms.TextBox();
            this.lDownloads = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenPersonal);
            this.groupBox1.Controls.Add(this.btnSetPersonal);
            this.groupBox1.Controls.Add(this.tbPersonal);
            this.groupBox1.Controls.Add(this.lPersonal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Documents";
            // 
            // btnOpenPersonal
            // 
            this.btnOpenPersonal.Location = new System.Drawing.Point(358, 35);
            this.btnOpenPersonal.Name = "btnOpenPersonal";
            this.btnOpenPersonal.Size = new System.Drawing.Size(25, 23);
            this.btnOpenPersonal.TabIndex = 1;
            this.btnOpenPersonal.Text = "...";
            this.btnOpenPersonal.UseVisualStyleBackColor = true;
            this.btnOpenPersonal.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnSetPersonal
            // 
            this.btnSetPersonal.Enabled = false;
            this.btnSetPersonal.Location = new System.Drawing.Point(389, 35);
            this.btnSetPersonal.Name = "btnSetPersonal";
            this.btnSetPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnSetPersonal.TabIndex = 2;
            this.btnSetPersonal.Text = "Move";
            this.btnSetPersonal.UseVisualStyleBackColor = true;
            this.btnSetPersonal.Click += new System.EventHandler(this.Move_Click);
            // 
            // tbPersonal
            // 
            this.tbPersonal.Location = new System.Drawing.Point(7, 37);
            this.tbPersonal.Name = "tbPersonal";
            this.tbPersonal.Size = new System.Drawing.Size(345, 20);
            this.tbPersonal.TabIndex = 0;
            this.tbPersonal.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lPersonal
            // 
            this.lPersonal.AutoSize = true;
            this.lPersonal.Location = new System.Drawing.Point(48, 20);
            this.lPersonal.Name = "lPersonal";
            this.lPersonal.Size = new System.Drawing.Size(57, 13);
            this.lPersonal.TabIndex = 4;
            this.lPersonal.Text = "(unknown)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenDesktop);
            this.groupBox2.Controls.Add(this.btnSetDesktop);
            this.groupBox2.Controls.Add(this.tbDesktop);
            this.groupBox2.Controls.Add(this.lDesktop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desktop";
            // 
            // btnOpenDesktop
            // 
            this.btnOpenDesktop.Location = new System.Drawing.Point(358, 35);
            this.btnOpenDesktop.Name = "btnOpenDesktop";
            this.btnOpenDesktop.Size = new System.Drawing.Size(25, 23);
            this.btnOpenDesktop.TabIndex = 1;
            this.btnOpenDesktop.Text = "...";
            this.btnOpenDesktop.UseVisualStyleBackColor = true;
            this.btnOpenDesktop.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnSetDesktop
            // 
            this.btnSetDesktop.Enabled = false;
            this.btnSetDesktop.Location = new System.Drawing.Point(389, 35);
            this.btnSetDesktop.Name = "btnSetDesktop";
            this.btnSetDesktop.Size = new System.Drawing.Size(75, 23);
            this.btnSetDesktop.TabIndex = 2;
            this.btnSetDesktop.Text = "Move";
            this.btnSetDesktop.UseVisualStyleBackColor = true;
            this.btnSetDesktop.Click += new System.EventHandler(this.Move_Click);
            // 
            // tbDesktop
            // 
            this.tbDesktop.Location = new System.Drawing.Point(7, 37);
            this.tbDesktop.Name = "tbDesktop";
            this.tbDesktop.Size = new System.Drawing.Size(345, 20);
            this.tbDesktop.TabIndex = 0;
            this.tbDesktop.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lDesktop
            // 
            this.lDesktop.AutoSize = true;
            this.lDesktop.Location = new System.Drawing.Point(48, 21);
            this.lDesktop.Name = "lDesktop";
            this.lDesktop.Size = new System.Drawing.Size(57, 13);
            this.lDesktop.TabIndex = 4;
            this.lDesktop.Text = "(unknown)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOpenVideo);
            this.groupBox4.Controls.Add(this.btnSetVideo);
            this.groupBox4.Controls.Add(this.tbVideo);
            this.groupBox4.Controls.Add(this.lVideo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 65);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "My Video";
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Location = new System.Drawing.Point(358, 35);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(25, 23);
            this.btnOpenVideo.TabIndex = 1;
            this.btnOpenVideo.Text = "...";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnSetVideo
            // 
            this.btnSetVideo.Enabled = false;
            this.btnSetVideo.Location = new System.Drawing.Point(389, 35);
            this.btnSetVideo.Name = "btnSetVideo";
            this.btnSetVideo.Size = new System.Drawing.Size(75, 23);
            this.btnSetVideo.TabIndex = 2;
            this.btnSetVideo.Text = "Move";
            this.btnSetVideo.UseVisualStyleBackColor = true;
            this.btnSetVideo.Click += new System.EventHandler(this.Move_Click);
            // 
            // tbVideo
            // 
            this.tbVideo.Location = new System.Drawing.Point(7, 37);
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(345, 20);
            this.tbVideo.TabIndex = 0;
            this.tbVideo.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lVideo
            // 
            this.lVideo.AutoSize = true;
            this.lVideo.Location = new System.Drawing.Point(48, 20);
            this.lVideo.Name = "lVideo";
            this.lVideo.Size = new System.Drawing.Size(57, 13);
            this.lVideo.TabIndex = 4;
            this.lVideo.Text = "(unknown)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Source:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOpenMusic);
            this.groupBox5.Controls.Add(this.btnSetMusic);
            this.groupBox5.Controls.Add(this.tbMusic);
            this.groupBox5.Controls.Add(this.lMusic);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(12, 296);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 65);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "My Music";
            // 
            // btnOpenMusic
            // 
            this.btnOpenMusic.Location = new System.Drawing.Point(358, 35);
            this.btnOpenMusic.Name = "btnOpenMusic";
            this.btnOpenMusic.Size = new System.Drawing.Size(25, 23);
            this.btnOpenMusic.TabIndex = 1;
            this.btnOpenMusic.Text = "...";
            this.btnOpenMusic.UseVisualStyleBackColor = true;
            this.btnOpenMusic.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnSetMusic
            // 
            this.btnSetMusic.Enabled = false;
            this.btnSetMusic.Location = new System.Drawing.Point(389, 35);
            this.btnSetMusic.Name = "btnSetMusic";
            this.btnSetMusic.Size = new System.Drawing.Size(75, 23);
            this.btnSetMusic.TabIndex = 2;
            this.btnSetMusic.Text = "Move";
            this.btnSetMusic.UseVisualStyleBackColor = true;
            this.btnSetMusic.Click += new System.EventHandler(this.Move_Click);
            // 
            // tbMusic
            // 
            this.tbMusic.Location = new System.Drawing.Point(7, 37);
            this.tbMusic.Name = "tbMusic";
            this.tbMusic.Size = new System.Drawing.Size(345, 20);
            this.tbMusic.TabIndex = 0;
            this.tbMusic.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lMusic
            // 
            this.lMusic.AutoSize = true;
            this.lMusic.Location = new System.Drawing.Point(48, 20);
            this.lMusic.Name = "lMusic";
            this.lMusic.Size = new System.Drawing.Size(57, 13);
            this.lMusic.TabIndex = 4;
            this.lMusic.Text = "(unknown)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Source:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnOpenPictures);
            this.groupBox6.Controls.Add(this.btnSetPictures);
            this.groupBox6.Controls.Add(this.tbPictures);
            this.groupBox6.Controls.Add(this.lPictures);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(12, 367);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(470, 65);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "My Pictures";
            // 
            // btnOpenPictures
            // 
            this.btnOpenPictures.Location = new System.Drawing.Point(358, 35);
            this.btnOpenPictures.Name = "btnOpenPictures";
            this.btnOpenPictures.Size = new System.Drawing.Size(25, 23);
            this.btnOpenPictures.TabIndex = 1;
            this.btnOpenPictures.Text = "...";
            this.btnOpenPictures.UseVisualStyleBackColor = true;
            this.btnOpenPictures.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnSetPictures
            // 
            this.btnSetPictures.Enabled = false;
            this.btnSetPictures.Location = new System.Drawing.Point(389, 35);
            this.btnSetPictures.Name = "btnSetPictures";
            this.btnSetPictures.Size = new System.Drawing.Size(75, 23);
            this.btnSetPictures.TabIndex = 2;
            this.btnSetPictures.Text = "Move";
            this.btnSetPictures.UseVisualStyleBackColor = true;
            this.btnSetPictures.Click += new System.EventHandler(this.Move_Click);
            // 
            // tbPictures
            // 
            this.tbPictures.Location = new System.Drawing.Point(7, 37);
            this.tbPictures.Name = "tbPictures";
            this.tbPictures.Size = new System.Drawing.Size(345, 20);
            this.tbPictures.TabIndex = 0;
            this.tbPictures.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lPictures
            // 
            this.lPictures.AutoSize = true;
            this.lPictures.Location = new System.Drawing.Point(48, 20);
            this.lPictures.Name = "lPictures";
            this.lPictures.Size = new System.Drawing.Size(57, 13);
            this.lPictures.TabIndex = 4;
            this.lPictures.Text = "(unknown)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Source:";
            // 
            // fbDialog
            // 
            this.fbDialog.Description = "VIN: MUF - Choice folder";
            this.fbDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Enabled = false;
            this.labelAbout.Location = new System.Drawing.Point(373, 450);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(109, 13);
            this.labelAbout.TabIndex = 8;
            this.labelAbout.Text = "Daniel Swan ©  2016";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnOpenDownloads);
            this.groupBox7.Controls.Add(this.btnSetDownloads);
            this.groupBox7.Controls.Add(this.tbDownloads);
            this.groupBox7.Controls.Add(this.lDownloads);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(12, 83);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(470, 65);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Downloads";
            // 
            // btnOpenDownloads
            // 
            this.btnOpenDownloads.Location = new System.Drawing.Point(358, 35);
            this.btnOpenDownloads.Name = "btnOpenDownloads";
            this.btnOpenDownloads.Size = new System.Drawing.Size(25, 23);
            this.btnOpenDownloads.TabIndex = 1;
            this.btnOpenDownloads.Text = "...";
            this.btnOpenDownloads.UseVisualStyleBackColor = true;
            this.btnOpenDownloads.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnSetDownloads
            // 
            this.btnSetDownloads.Enabled = false;
            this.btnSetDownloads.Location = new System.Drawing.Point(389, 35);
            this.btnSetDownloads.Name = "btnSetDownloads";
            this.btnSetDownloads.Size = new System.Drawing.Size(75, 23);
            this.btnSetDownloads.TabIndex = 2;
            this.btnSetDownloads.Text = "Move";
            this.btnSetDownloads.UseVisualStyleBackColor = true;
            this.btnSetDownloads.Click += new System.EventHandler(this.Move_Click);
            // 
            // tbDownloads
            // 
            this.tbDownloads.Location = new System.Drawing.Point(7, 37);
            this.tbDownloads.Name = "tbDownloads";
            this.tbDownloads.Size = new System.Drawing.Size(345, 20);
            this.tbDownloads.TabIndex = 0;
            this.tbDownloads.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lDownloads
            // 
            this.lDownloads.AutoSize = true;
            this.lDownloads.Location = new System.Drawing.Point(48, 20);
            this.lDownloads.Name = "lDownloads";
            this.lDownloads.Size = new System.Drawing.Size(57, 13);
            this.lDownloads.TabIndex = 4;
            this.lDownloads.Text = "(unknown)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Source:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 438);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.Form1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 472);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIN: Move User Folders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetPersonal;
        private System.Windows.Forms.TextBox tbPersonal;
        private System.Windows.Forms.Label lPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSetDesktop;
        private System.Windows.Forms.TextBox tbDesktop;
        private System.Windows.Forms.Label lDesktop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenPersonal;
        private System.Windows.Forms.Button btnOpenDesktop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnSetVideo;
        private System.Windows.Forms.TextBox tbVideo;
        private System.Windows.Forms.Label lVideo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnOpenMusic;
        private System.Windows.Forms.Button btnSetMusic;
        private System.Windows.Forms.TextBox tbMusic;
        private System.Windows.Forms.Label lMusic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnOpenPictures;
        private System.Windows.Forms.Button btnSetPictures;
        private System.Windows.Forms.TextBox tbPictures;
        private System.Windows.Forms.Label lPictures;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnOpenDownloads;
        private System.Windows.Forms.Button btnSetDownloads;
        private System.Windows.Forms.TextBox tbDownloads;
        private System.Windows.Forms.Label lDownloads;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefresh;
    }
}

