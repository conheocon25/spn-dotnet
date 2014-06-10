namespace ThuyetPhapApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvCategory = new System.Windows.Forms.TreeView();
            this.imApp = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sfMovie = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.lvVideo = new System.Windows.Forms.ListView();
            this.imVideo = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvCategory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(916, 741);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvCategory
            // 
            this.trvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvCategory.ImageIndex = 0;
            this.trvCategory.ImageList = this.imApp;
            this.trvCategory.Location = new System.Drawing.Point(0, 0);
            this.trvCategory.Name = "trvCategory";
            this.trvCategory.SelectedImageIndex = 0;
            this.trvCategory.Size = new System.Drawing.Size(304, 741);
            this.trvCategory.TabIndex = 2;
            this.trvCategory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvCategory_NodeMouseClick);
            // 
            // imApp
            // 
            this.imApp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imApp.ImageStream")));
            this.imApp.TransparentColor = System.Drawing.Color.Transparent;
            this.imApp.Images.SetKeyName(0, "Folder-icon.png");
            this.imApp.Images.SetKeyName(1, "Folder-Open-icon.png");
            this.imApp.Images.SetKeyName(2, "YouTube-icon.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sfMovie);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvVideo);
            this.splitContainer2.Size = new System.Drawing.Size(608, 741);
            this.splitContainer2.SplitterDistance = 377;
            this.splitContainer2.TabIndex = 1;
            // 
            // sfMovie
            // 
            this.sfMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfMovie.Enabled = true;
            this.sfMovie.Location = new System.Drawing.Point(0, 0);
            this.sfMovie.Name = "sfMovie";
            this.sfMovie.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sfMovie.OcxState")));
            this.sfMovie.Size = new System.Drawing.Size(608, 377);
            this.sfMovie.TabIndex = 2;
            // 
            // lvVideo
            // 
            this.lvVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVideo.LargeImageList = this.imVideo;
            this.lvVideo.Location = new System.Drawing.Point(0, 0);
            this.lvVideo.Name = "lvVideo";
            this.lvVideo.Size = new System.Drawing.Size(608, 360);
            this.lvVideo.SmallImageList = this.imVideo;
            this.lvVideo.TabIndex = 2;
            this.lvVideo.UseCompatibleStateImageBehavior = false;
            this.lvVideo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvVideo_MouseDoubleClick);
            // 
            // imVideo
            // 
            this.imVideo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imVideo.ImageStream")));
            this.imVideo.TransparentColor = System.Drawing.Color.Transparent;
            this.imVideo.Images.SetKeyName(0, "YouTube-icon.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 741);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng Thuyết Pháp - Chùa Long Viễn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvCategory;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ImageList imApp;
        private System.Windows.Forms.ImageList imVideo;
        private AxShockwaveFlashObjects.AxShockwaveFlash sfMovie;
        private System.Windows.Forms.ListView lvVideo;

    }
}

