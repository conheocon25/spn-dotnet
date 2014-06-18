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
            /*
            string UserState = "Testing ...";
            MailMessage message = this.Template.getMail();
            SmtpClient smtpClient = CApp.Sender._smtpClient;

            message.To.Add(this.Customer.Email);
            smtpClient.SendAsync(message, UserState);
             */
        }

    }    
}
