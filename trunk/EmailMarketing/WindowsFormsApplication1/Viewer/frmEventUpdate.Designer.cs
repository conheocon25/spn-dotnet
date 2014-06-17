namespace EmailMarketing
{
    partial class frmEventUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventUpdate));
            this.label4 = new System.Windows.Forms.Label();
            this.cboTemplate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mẫu";
            // 
            // cboTemplate
            // 
            this.cboTemplate.FormattingEnabled = true;
            this.cboTemplate.Location = new System.Drawing.Point(234, 168);
            this.cboTemplate.Name = "cboTemplate";
            this.cboTemplate.Size = new System.Drawing.Size(187, 21);
            this.cboTemplate.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nhóm";
            // 
            // cboTag
            // 
            this.cboTag.FormattingEnabled = true;
            this.cboTag.Location = new System.Drawing.Point(234, 141);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(187, 21);
            this.cboTag.TabIndex = 24;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(234, 115);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(187, 20);
            this.dtpTime.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(234, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 31);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Lưu";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thời gian";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên sự kiện";
            // 
            // frmEventUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTemplate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTag);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEventUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Marketing > Sự Kiện > Cập nhật";
            this.Load += new System.EventHandler(this.frmEventUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTag;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}