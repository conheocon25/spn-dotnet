using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net.Mail;
using System.Net;

namespace EmailMarketing
{
    public class CScheduler
    {
        private int _Id;        
        private DateTime _Time;
        private int _IdTemplate;
        private int _IdCustomer;
        private int _State;

        public CScheduler(int Id = 0, DateTime Time = new DateTime(), int IdTemplate = 0, int IdCustomer = 0, int State = 0)
        {
            this._Id = Id;            
            this._Time = Time;
            this._IdTemplate = IdTemplate;
            this._IdCustomer = IdCustomer;
        }
        
        [DisplayName("Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = Id;
            }
        }

        [Browsable(false)]
        public int IdTemplate
        {
            get
            {
                return this._IdTemplate;
            }
            set
            {
                this._IdTemplate = IdTemplate;
            }
        }
        
        public CTemplate getTemplate()
        {
            var mTemplate = new CTemplateMapper();
            return mTemplate.get(this._IdTemplate);
        }

        [DisplayName("Thời điểm")]
        public DateTime Time
        {
            get
            {
                return this._Time;
            }
            set
            {
                this._Time = Time;
            }
        }

        [Browsable(false)]
        public int IdCustomer
        {
            get
            {
                return this._IdCustomer;
            }
            set
            {
                this._IdCustomer = IdCustomer;
            }
        }

        public CCustomer getCustomer() {
            var mCustomer = new CCustomerMapper();
            return mCustomer.get(this._IdCustomer);
        }
                
        //[Browsable(false)]
        public int State
        {
            get
            {
                return this._State;
            }
            set
            {
                this._State = State;
            }
        }

        public void sendMail() {
            string UserState = "Đang thử nghiệm ...";
            MailMessage message = this.getTemplate().getEmail();
            SmtpClient smtpClient = CApp.Sender._smtpClient;
            message.To.Add(this.getCustomer().Email);
            smtpClient.SendAsync(message, UserState);            
        }

    }    
}
