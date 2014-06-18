using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Configuration;

namespace EmailMarketing
{
    public class CSender
    {        
        
        public string UserName;
        public string UserPass;

        public SmtpClient _smtpClient;
        public CSender() {
            
            string Emailpassword = ConfigurationManager.AppSettings["password"];
            this.UserName = ConfigurationManager.AppSettings["sender"];            
            this.UserPass = MyEncrypt.Decrypt(Emailpassword,"654789spncompanyadmin368068...");
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
                CApp.bNextMessage = true;
                CApp.nSend += 1;
                CApp.nSum -= 1;

                //Đánh dấu là thư đã được gửi
                var mScheduler = new CSchedulerMapper();
                var Scheduler = mScheduler.get(CApp.iScheduler);
                var mLog = new CLogMapper();
                mLog.insert(new CLog(1, Scheduler.Time, DateTime.Now, Scheduler.IdTemplate, Scheduler.IdCustomer, 1));
                mScheduler.delete(CApp.iScheduler);
            }
                
        }
    }
}
