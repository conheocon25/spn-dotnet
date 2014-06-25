namespace KaraokeBaDuc
{
    partial class FrmDomainInsert
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
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.txtNameDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Location = new System.Drawing.Point(128, 65);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(53, 24);
            this.btnAddDomain.TabIndex = 0;
            this.btnAddDomain.Text = "Thêm";
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // txtNameDomain
            // 
            this.txtNameDomain.Location = new System.Drawing.Point(81, 26);
            this.txtNameDomain.Name = "txtNameDomain";
            this.txtNameDomain.Size = new System.Drawing.Size(213, 20);
            this.txtNameDomain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khu vực";
            // 
            // FrmDomainInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 104);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameDomain);
            this.Controls.Add(this.btnAddDomain);
            this.Name = "FrmDomainInsert";
            this.Text = "Cấu Hình > Khu Vực > Thêm Mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.TextBox txtNameDomain;
        private System.Windows.Forms.Label label1;
    }
}