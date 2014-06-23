namespace RestaurantApp
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
            this.mnuSystem = new System.Windows.Forms.MenuStrip();
            this.mnuSelling = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.hômNayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thángNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnVịTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSystem
            // 
            this.mnuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelling,
            this.mnuReport,
            this.mnuImport,
            this.mnuSetting,
            this.mnuAbout});
            this.mnuSystem.Location = new System.Drawing.Point(0, 0);
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(792, 24);
            this.mnuSystem.TabIndex = 0;
            this.mnuSystem.Text = "menuStrip1";
            // 
            // mnuSelling
            // 
            this.mnuSelling.Name = "mnuSelling";
            this.mnuSelling.Size = new System.Drawing.Size(64, 20);
            this.mnuSelling.Text = "Bán hàng";
            this.mnuSelling.Click += new System.EventHandler(this.mnuSelling_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hômNayToolStripMenuItem,
            this.thángNàyToolStripMenuItem});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(57, 20);
            this.mnuReport.Text = "Báo cáo";
            // 
            // hômNayToolStripMenuItem
            // 
            this.hômNayToolStripMenuItem.Name = "hômNayToolStripMenuItem";
            this.hômNayToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hômNayToolStripMenuItem.Text = "Hôm nay";
            // 
            // thángNàyToolStripMenuItem
            // 
            this.thángNàyToolStripMenuItem.Name = "thángNàyToolStripMenuItem";
            this.thángNàyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.thángNàyToolStripMenuItem.Text = "Tháng này";
            // 
            // mnuImport
            // 
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(71, 20);
            this.mnuImport.Text = "Nhập hàng";
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khuVựcToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.mónToolStripMenuItem,
            this.đơnVịTínhToolStripMenuItem,
            this.mnuUser});
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(60, 20);
            this.mnuSetting.Text = "Thiết lập";
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.khuVựcToolStripMenuItem.Text = "Khu vực";
            this.khuVựcToolStripMenuItem.Click += new System.EventHandler(this.khuVựcToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // mónToolStripMenuItem
            // 
            this.mónToolStripMenuItem.Name = "mónToolStripMenuItem";
            this.mónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mónToolStripMenuItem.Text = "Món";
            // 
            // đơnVịTínhToolStripMenuItem
            // 
            this.đơnVịTínhToolStripMenuItem.Name = "đơnVịTínhToolStripMenuItem";
            this.đơnVịTínhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đơnVịTínhToolStripMenuItem.Text = "Đơn vị tính";
            // 
            // mnuUser
            // 
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(152, 22);
            this.mnuUser.Text = "Người dùng";
            this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(63, 20);
            this.mnuAbout.Text = "Giới thiệu";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestaurantApp.Properties.Resources.bg_fix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.mnuSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuSystem;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuSystem.ResumeLayout(false);
            this.mnuSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuSelling;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem hômNayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thángNàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnVịTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}

