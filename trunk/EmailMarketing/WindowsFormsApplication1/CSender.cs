using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

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
        }

    }
}
