namespace KaraokeBaDuc
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
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfigDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfigRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSystem
            // 
            this.mnuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.mnuAbout});
            this.mnuSystem.Location = new System.Drawing.Point(0, 0);
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(695, 24);
            this.mnuSystem.TabIndex = 1;
            this.mnuSystem.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerView,
            this.mnuConfig});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.dataToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuCustomerView
            // 
            this.mnuCustomerView.Name = "mnuCustomerView";
            this.mnuCustomerView.Size = new System.Drawing.Size(152, 22);
            this.mnuCustomerView.Text = "Bán hàng";
            // 
            // mnuConfig
            // 
            this.mnuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfigDomain,
            this.mnuConfigRoom});
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(152, 22);
            this.mnuConfig.Text = "Cấu hình";
            // 
            // mnuConfigDomain
            // 
            this.mnuConfigDomain.Name = "mnuConfigDomain";
            this.mnuConfigDomain.Size = new System.Drawing.Size(154, 22);
            this.mnuConfigDomain.Text = "Khu Vực";
            this.mnuConfigDomain.Click += new System.EventHandler(this.mnuConfigDomain_Click);
            // 
            // mnuConfigRoom
            // 
            this.mnuConfigRoom.Name = "mnuConfigRoom";
            this.mnuConfigRoom.Size = new System.Drawing.Size(154, 22);
            this.mnuConfigRoom.Text = "Phòng Karaoke";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.aboutToolStripMenuItem.Text = "Bán Hàng";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(70, 20);
            this.mnuAbout.Text = "Giới thiệu";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 393);
            this.Controls.Add(this.mnuSystem);
            this.Name = "frmMain";
            this.Text = "Quan Ly Karaoke - Ba Duc";
            this.mnuSystem.ResumeLayout(false);
            this.mnuSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerView;
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigDomain;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigRoom;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}

