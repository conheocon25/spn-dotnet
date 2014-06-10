using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSendMail_Click(object sender, EventArgs e)
        {
            string result = SendMail(txtEmail.Text, "thanhbao2007vl@gmail.com", txtCCEmail.Text, txtSubject.Text, txtContent.Text);
            MessageBox.Show(result);
        }
        public string SendMail(string toList, string from, string ccList,string subject, string body)
        {

            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;
            try
            {
                MailAddress fromAddress = new MailAddress(from);
                message.From = fromAddress;
                message.To.Add(toList);
                if (ccList != null && ccList != string.Empty)
                    message.CC.Add(ccList);
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = body;
                // We use gmail as our smtp client
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(
                    "thanhbao2007vl@gmail.com", "nhatkyty25");

                smtpClient.Send(message);
                msg = "Gửi Mail Thành Công";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 100;
            tt.ShowAlways = true;
            tt.SetToolTip(txtEmail, "Nhập email cần gửi vào đây!.");
        }

        private void txtCCEmail_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 100;
            tt.ShowAlways = true;
            tt.SetToolTip(txtCCEmail, "Nhập email cần gửi CC vào đây!.");
        }
        
    }
}
