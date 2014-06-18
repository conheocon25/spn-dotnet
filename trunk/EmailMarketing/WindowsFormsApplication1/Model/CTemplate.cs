using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net.Mail;
using System.Net;

namespace EmailMarketing
{
    public class CTemplate
    {
                
        [DisplayName("Id")]        
        public int Id { get; set; } 

        [DisplayName("Tên")]        
        public string Name { get; set; }

        [DisplayName("Nội dung")]
        public string Content{ get; set; }

        public CTemplate(int Id = 0, string Name = "", string Content = "")
        {
            this.Id = Id;
            this.Name = Name;
            this.Content = Content;
        }

        public MailMessage getEmail()
        {
            MailMessage Mail = new MailMessage();
            MailAddress From = new MailAddress("thanhbao2007vl@gmail.com", "Thanh Bảo");
            Mail.IsBodyHtml = true;
            Mail.From = From;
            Mail.Subject = this.Name;
            Mail.Body = this.Content;
            return Mail;
        }

    }
}
