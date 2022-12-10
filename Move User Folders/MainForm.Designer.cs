namespace MUF
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
            this.components = new System.ComponentModel.Container();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.info = new System.Windows.Forms.Label();
            this.cbFoldersList = new System.Windows.Forms.ComboBox();
            this.folderImg = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.chbContent = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.folderImg)).BeginInit();
            this.SuspendLayout();
            // 
            // fbDialog
            // 
            this.fbDialog.Description = "VIN: MUF - Choice folder";
            this.fbDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.info.AutoSize = true;
            this.info.Enabled = false;
            this.info.Location = new System.Drawing.Point(350, 135);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(139, 13);
            this.info.TabIndex = 8;
            this.info.Text = "Daniel Swan ©  2016, 2022";
            // 
            // cbFoldersList
            // 
            this.cbFoldersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoldersList.Items.AddRange(new object[] {
            "Desktop",
            "My Documents",
            "My Videos",
            "My Music",
            "My Pictures",
            "Downloads"});
            this.cbFoldersList.Location = new System.Drawing.Point(156, 12);
            this.cbFoldersList.Name = "cbFoldersList";
            this.cbFoldersList.Size = new System.Drawing.Size(254, 21);
            this.cbFoldersList.TabIndex = 0;
            this.cbFoldersList.SelectedIndexChanged += new System.EventHandler(this.cbFoldersList_SelectedIndexChanged);
            // 
            // folderImg
            // 
            this.folderImg.BackgroundImage = global::MUF.Resources.DesktopImage;
            this.folderImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.folderImg.Location = new System.Drawing.Point(5, 5);
            this.folderImg.Name = "folderImg";
            this.folderImg.Size = new System.Drawing.Size(145, 145);
            this.folderImg.TabIndex = 17;
            this.folderImg.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MUF.Resources.RefreshImage;
            this.btnRefresh.Location = new System.Drawing.Point(416, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 18;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Image = global::MUF.Resources.ApplyImage;
            this.btnApply.Location = new System.Drawing.Point(452, 6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(30, 30);
            this.btnApply.TabIndex = 19;
            this.toolTip.SetToolTip(this.btnApply, "Apply and move");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chbContent
            // 
            this.chbContent.AutoSize = true;
            this.chbContent.Location = new System.Drawing.Point(175, 90);
            this.chbContent.Name = "chbContent";
            this.chbContent.Size = new System.Drawing.Size(114, 17);
            this.chbContent.TabIndex = 23;
            this.chbContent.Text = "Move with content";
            this.chbContent.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::MUF.Resources.OpenFolder;
            this.btnOpen.Location = new System.Drawing.Point(452, 49);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(30, 30);
            this.btnOpen.TabIndex = 22;
            this.toolTip.SetToolTip(this.btnOpen, "Open folder");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtTarget.Location = new System.Drawing.Point(156, 55);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(254, 20);
            this.txtTarget.TabIndex = 20;
            this.txtTarget.TextChanged += new System.EventHandler(this.txtTarget_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(416, 49);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 30);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "...";
            this.toolTip.SetToolTip(this.btnBrowse, "Browse");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 152);
            this.Controls.Add(this.chbContent);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbFoldersList);
            this.Controls.Add(this.info);
            this.Controls.Add(this.folderImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 180);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIN: Move User Folders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folderImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ComboBox cbFoldersList;
        private System.Windows.Forms.PictureBox folderImg;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chbContent;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

