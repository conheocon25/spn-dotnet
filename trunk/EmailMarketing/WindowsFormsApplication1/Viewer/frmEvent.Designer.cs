namespace EmailMarketing
{
    partial class frmEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvent));
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.mnuAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.mnuAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvent
            // 
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvent.Location = new System.Drawing.Point(0, 0);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.Size = new System.Drawing.Size(792, 573);
            this.dgvEvent.TabIndex = 2;

            this.dgvEvent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gdvEvent_MouseClick);
            // 
            // mnuAction
            // 
            this.mnuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInsert,
            this.mnuUpdate,
            this.mnuDelete});
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(119, 70);
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.Size = new System.Drawing.Size(118, 22);
            this.mnuInsert.Text = "Thêm";
            this.mnuInsert.Click += new System.EventHandler(this.mnuInsert_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(118, 22);
            this.mnuUpdate.Text = "Cập nhật";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(118, 22);
            this.mnuDelete.Text = "Xóa";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.dgvEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Marketing > Sự kiện";
            this.Load += new System.EventHandler(this.frmEventView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.mnuAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.ContextMenuStrip mnuAction;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}