using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace EmailMarketing
{
    public class CSender
    {
        public string UserName = "thanhbao2007vl@gmail.com";
        public string UserPass = "nhatkyty25";

        public SmtpClient _smtpClient;
        public CSender() {
            this._smtpClient = new SmtpClient();
            this._smtpClient.Host = "smtp.gmail.com";
            this._smtpClient.Port = 587;
            this._smtpClient.EnableSsl = true;
            this._smtpClient.UseDefaultCredentials = true;
            this._smtpClient.Credentials = new System.Net.NetworkCredential(UserName, UserPass);

            this._smtpClient.SendCompleted += new SendCompletedEventHandler(MailDeliveryComplete);
        }
        static void MailDeliveryComplete(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {            

            if (e.Error != null) {
                //Console.WriteLine("Error sending email.");
                MessageBox.Show("Loi trong luc gui");
                CApp.bNextMessage = true;
            }
            else if (e.Cancelled)
            {
                //Console.WriteLine("Sending of email cancelled.");
                MessageBox.Show("Gui bi huy");
                CApp.bNextMessage = true;
            }
            else
            {
                //Console.WriteLine("Message sent.");
                CApp.bNextMessage = true;
                                
                //Đánh dấu là thư đã được gửi
            }
                
        }


    }
}
