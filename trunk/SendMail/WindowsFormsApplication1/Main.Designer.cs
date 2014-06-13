namespace WindowsFormsApplication1
{
    partial class Main
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSendMail = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtCCEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuEncryptString = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInfoApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gửi đến Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nội dung gửi:";
            // 
            // btSendMail
            // 
            this.btSendMail.Location = new System.Drawing.Point(123, 217);
            this.btSendMail.Name = "btSendMail";
            this.btSendMail.Size = new System.Drawing.Size(102, 34);
            this.btSendMail.TabIndex = 4;
            this.btSendMail.Text = "SendMail";
            this.btSendMail.UseVisualStyleBackColor = true;
            this.btSendMail.Click += new System.EventHandler(this.btSendMail_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(391, 214);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(95, 37);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chủ Đề:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(98, 77);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(211, 20);
            this.txtSubject.TabIndex = 6;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(98, 103);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(388, 108);
            this.txtContent.TabIndex = 8;
            // 
            // txtCCEmail
            // 
            this.txtCCEmail.Location = new System.Drawing.Point(373, 51);
            this.txtCCEmail.Name = "txtCCEmail";
            this.txtCCEmail.Size = new System.Drawing.Size(211, 20);
            this.txtCCEmail.TabIndex = 9;
            this.txtCCEmail.Enter += new System.EventHandler(this.txtCCEmail_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CC Email:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEncryptString,
            this.EncryptToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuEncryptString
            // 
            this.MenuEncryptString.Name = "MenuEncryptString";
            this.MenuEncryptString.Size = new System.Drawing.Size(12, 20);
            // 
            // EncryptToolStripMenuItem
            // 
            this.EncryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEncrypt});
            this.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem";
            this.EncryptToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.EncryptToolStripMenuItem.Text = "Mã Hóa";
            this.EncryptToolStripMenuItem.Click += new System.EventHandler(this.EncryptToolStripMenuItem_Click);
            // 
            // MenuEncrypt
            // 
            this.MenuEncrypt.AutoToolTip = true;
            this.MenuEncrypt.Name = "MenuEncrypt";
            this.MenuEncrypt.Size = new System.Drawing.Size(152, 22);
            this.MenuEncrypt.Text = "Mã hóa chuỗi";
            this.MenuEncrypt.Click += new System.EventHandler(this.MenuEncrypt_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInfoApp});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // MenuInfoApp
            // 
            this.MenuInfoApp.Name = "MenuInfoApp";
            this.MenuInfoApp.Size = new System.Drawing.Size(182, 22);
            this.MenuInfoApp.Text = "Thông tin Ứng dụng";
            this.MenuInfoApp.Click += new System.EventHandler(this.MenuInfoApp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCCEmail);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSendMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSendMail;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtCCEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuEncryptString;
        private System.Windows.Forms.ToolStripMenuItem EncryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEncrypt;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuInfoApp;
    }
}

