namespace KaraokeBaDuc
{
    partial class FrmDomain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvDomain = new System.Windows.Forms.DataGridView();
            this.mnuAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomain)).BeginInit();
            this.mnuAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDomain
            // 
            this.dgvDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomain.ContextMenuStrip = this.mnuAction;
            this.dgvDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDomain.Location = new System.Drawing.Point(0, 0);
            this.dgvDomain.Name = "dgvDomain";
            this.dgvDomain.Size = new System.Drawing.Size(634, 384);
            this.dgvDomain.TabIndex = 1;
            // 
            // mnuAction
            // 
            this.mnuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInsert,
            this.mnuUpdate,
            this.mnuDelete});
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(153, 92);
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.Size = new System.Drawing.Size(152, 22);
            this.mnuInsert.Text = "Thêm";
            this.mnuInsert.Click += new System.EventHandler(this.mnuInsert_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(152, 22);
            this.mnuUpdate.Text = "Cập nhật";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(122, 22);
            this.mnuDelete.Text = "Xóa";
            // 
            // FrmDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 384);
            this.Controls.Add(this.dgvDomain);
            this.Name = "FrmDomain";
            this.Text = "Khu Vực";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomain)).EndInit();
            this.mnuAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDomain;
        private System.Windows.Forms.ContextMenuStrip mnuAction;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}