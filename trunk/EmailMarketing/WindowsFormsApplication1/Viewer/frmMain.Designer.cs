namespace EmailMarketing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuSystem = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTagView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleView = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuSystem.Size = new System.Drawing.Size(792, 24);
            this.mnuSystem.TabIndex = 0;
            this.mnuSystem.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTagView,
            this.mnuCustomerView,
            this.mnuTemplate,
            this.mnuEvent});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.dataToolStripMenuItem.Text = "Thông tin";
            // 
            // mnuTagView
            // 
            this.mnuTagView.Name = "mnuTagView";
            this.mnuTagView.Size = new System.Drawing.Size(152, 22);
            this.mnuTagView.Text = "Thẻ";
            this.mnuTagView.Click += new System.EventHandler(this.mnuTagView_Click);
            // 
            // mnuCustomerView
            // 
            this.mnuCustomerView.Name = "mnuCustomerView";
            this.mnuCustomerView.Size = new System.Drawing.Size(152, 22);
            this.mnuCustomerView.Text = "Khách hàng";
            this.mnuCustomerView.Click += new System.EventHandler(this.mnuCustomerView_Click);
            // 
            // mnuTemplate
            // 
            this.mnuTemplate.Name = "mnuTemplate";
            this.mnuTemplate.Size = new System.Drawing.Size(152, 22);
            this.mnuTemplate.Text = "Mẫu Email";
            this.mnuTemplate.Click += new System.EventHandler(this.mnuTemplate_Click);
            // 
            // mnuEvent
            // 
            this.mnuEvent.Name = "mnuEvent";
            this.mnuEvent.Size = new System.Drawing.Size(152, 22);
            this.mnuEvent.Text = "Sự kiện";
            this.mnuEvent.Click += new System.EventHandler(this.mnuEvent_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScheduleView});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aboutToolStripMenuItem.Text = "Lên lịch";
            // 
            // mnuScheduleView
            // 
            this.mnuScheduleView.Name = "mnuScheduleView";
            this.mnuScheduleView.Size = new System.Drawing.Size(94, 22);
            this.mnuScheduleView.Text = "Xem";
            this.mnuScheduleView.Click += new System.EventHandler(this.mnuScheduleView_Click);
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
            this.BackgroundImage = global::EmailMarketing.Properties.Resources.e_mail;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.mnuSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuSystem;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Marketing";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuSystem.ResumeLayout(false);
            this.mnuSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuTagView;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerView;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleView;
        private System.Windows.Forms.ToolStripMenuItem mnuTemplate;
        private System.Windows.Forms.ToolStripMenuItem mnuEvent;
    }
}

