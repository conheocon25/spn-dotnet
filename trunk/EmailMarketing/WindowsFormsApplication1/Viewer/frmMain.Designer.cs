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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuSystem = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTagView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSending = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ntiApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbSending = new System.Windows.Forms.ToolStripProgressBar();
            this.tmrSending = new System.Windows.Forms.Timer(this.components);
            this.tmrScheduler = new System.Windows.Forms.Timer(this.components);
            this.lblSchedulerState = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuSystem.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.mnuEvent,
            this.mnuConfig});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dataToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuTagView
            // 
            this.mnuTagView.Name = "mnuTagView";
            this.mnuTagView.Size = new System.Drawing.Size(130, 22);
            this.mnuTagView.Text = "Thẻ";
            this.mnuTagView.Click += new System.EventHandler(this.mnuTagView_Click);
            // 
            // mnuCustomerView
            // 
            this.mnuCustomerView.Name = "mnuCustomerView";
            this.mnuCustomerView.Size = new System.Drawing.Size(130, 22);
            this.mnuCustomerView.Text = "Khách hàng";
            this.mnuCustomerView.Click += new System.EventHandler(this.mnuCustomerView_Click);
            // 
            // mnuTemplate
            // 
            this.mnuTemplate.Name = "mnuTemplate";
            this.mnuTemplate.Size = new System.Drawing.Size(130, 22);
            this.mnuTemplate.Text = "Mẫu Email";
            this.mnuTemplate.Click += new System.EventHandler(this.mnuTemplate_Click);
            // 
            // mnuEvent
            // 
            this.mnuEvent.Name = "mnuEvent";
            this.mnuEvent.Size = new System.Drawing.Size(130, 22);
            this.mnuEvent.Text = "Sự kiện";
            this.mnuEvent.Click += new System.EventHandler(this.mnuEvent_Click);
            // 
            // mnuConfig
            // 
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(130, 22);
            this.mnuConfig.Text = "Cấu hình";
            this.mnuConfig.Click += new System.EventHandler(this.mnuConfig_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSending,
            this.mnuScheduleView,
            this.mnuLog});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.aboutToolStripMenuItem.Text = "Hành động";
            // 
            // mnuSending
            // 
            this.mnuSending.Name = "mnuSending";
            this.mnuSending.Size = new System.Drawing.Size(151, 22);
            this.mnuSending.Text = "Gửi tự động";
            this.mnuSending.Click += new System.EventHandler(this.mnuSending_Click);
            // 
            // mnuScheduleView
            // 
            this.mnuScheduleView.Name = "mnuScheduleView";
            this.mnuScheduleView.Size = new System.Drawing.Size(151, 22);
            this.mnuScheduleView.Text = "Phát sinh gửi ...";
            this.mnuScheduleView.Click += new System.EventHandler(this.mnuScheduleView_Click);
            // 
            // mnuLog
            // 
            this.mnuLog.Name = "mnuLog";
            this.mnuLog.Size = new System.Drawing.Size(151, 22);
            this.mnuLog.Text = "Nhật kí gửi";
            this.mnuLog.Click += new System.EventHandler(this.mnuLog_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(63, 20);
            this.mnuAbout.Text = "Giới thiệu";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // ntiApp
            // 
            this.ntiApp.BalloonTipText = "Hệ thống Email Marketing";
            this.ntiApp.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiApp.Icon")));
            this.ntiApp.Text = "Email Marketing";
            this.ntiApp.Visible = true;
            this.ntiApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiApp_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblState,
            this.pgbSending,
            this.lblSchedulerState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblState
            // 
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(73, 17);
            this.lblState.Text = "Đang rảnh ...";
            // 
            // pgbSending
            // 
            this.pgbSending.Maximum = 300;
            this.pgbSending.Name = "pgbSending";
            this.pgbSending.Size = new System.Drawing.Size(100, 16);
            // 
            // tmrSending
            // 
            this.tmrSending.Enabled = true;
            this.tmrSending.Interval = 1000;
            this.tmrSending.Tick += new System.EventHandler(this.tmrSending_Tick);
            // 
            // tmrScheduler
            // 
            this.tmrScheduler.Enabled = true;
            this.tmrScheduler.Interval = 5500;
            this.tmrScheduler.Tick += new System.EventHandler(this.tmrScheduler_Tick);
            // 
            // lblSchedulerState
            // 
            this.lblSchedulerState.Name = "lblSchedulerState";
            this.lblSchedulerState.Size = new System.Drawing.Size(89, 17);
            this.lblSchedulerState.Text = "Đang kiểm tra ...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmailMarketing.Properties.Resources._305;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuSystem;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Marketing";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mnuSystem.ResumeLayout(false);
            this.mnuSystem.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.NotifyIcon ntiApp;
        private System.Windows.Forms.ToolStripMenuItem mnuSending;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.ToolStripProgressBar pgbSending;
        private System.Windows.Forms.Timer tmrSending;
        private System.Windows.Forms.ToolStripMenuItem mnuLog;
        private System.Windows.Forms.Timer tmrScheduler;
        private System.Windows.Forms.ToolStripStatusLabel lblSchedulerState;
    }
}

