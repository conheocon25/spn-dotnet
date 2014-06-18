namespace EmailMarketing
{
    partial class frmScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduler));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstMain = new System.Windows.Forms.ListBox();
            this.prbSending = new System.Windows.Forms.ProgressBar();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.dgvScheduler = new System.Windows.Forms.DataGridView();
            this.tmrSending = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lstMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.prbSending);
            this.splitContainer1.Panel2.Controls.Add(this.lblProcessing);
            this.splitContainer1.Panel2.Controls.Add(this.cmdStart);
            this.splitContainer1.Panel2.Controls.Add(this.dgvScheduler);
            this.splitContainer1.Size = new System.Drawing.Size(792, 573);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstMain
            // 
            this.lstMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMain.FormattingEnabled = true;
            this.lstMain.Location = new System.Drawing.Point(0, 0);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(264, 573);
            this.lstMain.TabIndex = 0;
            this.lstMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMain_MouseDoubleClick);
            // 
            // prbSending
            // 
            this.prbSending.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prbSending.Location = new System.Drawing.Point(137, 535);
            this.prbSending.Name = "prbSending";
            this.prbSending.Size = new System.Drawing.Size(369, 23);
            this.prbSending.Step = 100;
            this.prbSending.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbSending.TabIndex = 3;
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.Location = new System.Drawing.Point(84, 535);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(38, 24);
            this.lblProcessing.TabIndex = 2;
            this.lblProcessing.Text = "0/0";
            // 
            // cmdStart
            // 
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.Location = new System.Drawing.Point(6, 528);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(72, 39);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "Bắt đầu";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // dgvScheduler
            // 
            this.dgvScheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduler.Location = new System.Drawing.Point(0, 0);
            this.dgvScheduler.Name = "dgvScheduler";
            this.dgvScheduler.Size = new System.Drawing.Size(524, 516);
            this.dgvScheduler.TabIndex = 0;
            // 
            // tmrSending
            // 
            this.tmrSending.Enabled = true;
            this.tmrSending.Interval = 1000;
            this.tmrSending.Tick += new System.EventHandler(this.tmrSending_Tick);
            // 
            // frmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Marketing > Lên lịch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScheduler_FormClosed);
            this.Load += new System.EventHandler(this.frmSchedulerView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.DataGridView dgvScheduler;
        private System.Windows.Forms.Timer tmrSending;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.ProgressBar prbSending;

    }
}