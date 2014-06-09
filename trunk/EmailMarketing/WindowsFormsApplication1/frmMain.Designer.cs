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
            this.mnuSystem = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerView = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventView = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSystem
            // 
            this.mnuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.mnuOption,
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
            this.mnuCustomerInsert,
            this.mnuCustomerView});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.dataToolStripMenuItem.Text = "Khách hàng";
            // 
            // mnuCustomerInsert
            // 
            this.mnuCustomerInsert.Name = "mnuCustomerInsert";
            this.mnuCustomerInsert.Size = new System.Drawing.Size(100, 22);
            this.mnuCustomerInsert.Text = "Thêm";
            this.mnuCustomerInsert.Click += new System.EventHandler(this.mnuCustomerInsert_Click);
            // 
            // mnuCustomerView
            // 
            this.mnuCustomerView.Name = "mnuCustomerView";
            this.mnuCustomerView.Size = new System.Drawing.Size(100, 22);
            this.mnuCustomerView.Text = "Xem";
            this.mnuCustomerView.Click += new System.EventHandler(this.mnuCustomerView_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEventInsert,
            this.mnuEventView});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.eventToolStripMenuItem.Text = "Sự kiện";
            // 
            // mnuEventInsert
            // 
            this.mnuEventInsert.Name = "mnuEventInsert";
            this.mnuEventInsert.Size = new System.Drawing.Size(152, 22);
            this.mnuEventInsert.Text = "Thêm";
            this.mnuEventInsert.Click += new System.EventHandler(this.mnuEventInsert_Click);
            // 
            // mnuEventView
            // 
            this.mnuEventView.Name = "mnuEventView";
            this.mnuEventView.Size = new System.Drawing.Size(152, 22);
            this.mnuEventView.Text = "Xem";
            this.mnuEventView.Click += new System.EventHandler(this.mnuEventView_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScheduleInsert,
            this.mnuScheduleView});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aboutToolStripMenuItem.Text = "Lên lịch";
            // 
            // mnuScheduleInsert
            // 
            this.mnuScheduleInsert.Name = "mnuScheduleInsert";
            this.mnuScheduleInsert.Size = new System.Drawing.Size(152, 22);
            this.mnuScheduleInsert.Text = "Thêm";
            this.mnuScheduleInsert.Click += new System.EventHandler(this.mnuScheduleInsert_Click);
            // 
            // mnuScheduleView
            // 
            this.mnuScheduleView.Name = "mnuScheduleView";
            this.mnuScheduleView.Size = new System.Drawing.Size(152, 22);
            this.mnuScheduleView.Text = "Xem";
            this.mnuScheduleView.Click += new System.EventHandler(this.mnuScheduleView_Click);
            // 
            // mnuOption
            // 
            this.mnuOption.Name = "mnuOption";
            this.mnuOption.Size = new System.Drawing.Size(60, 20);
            this.mnuOption.Text = "Thiết lập";
            this.mnuOption.Click += new System.EventHandler(this.mnuOption_Click);
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
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.mnuSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuSystem;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerView;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEventInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuEventView;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleView;
        private System.Windows.Forms.ToolStripMenuItem mnuOption;
    }
}

