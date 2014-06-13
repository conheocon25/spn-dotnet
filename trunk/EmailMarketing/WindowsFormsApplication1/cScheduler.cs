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
        private string _Name;
        private DateTime _Time;
        private int _IdTemplate;
        private int _IdCustomer;
        private bool _State;

        public CScheduler(int Id = 0, string Name = "", DateTime Time = new DateTime(), int IdTemplate = 0, int IdCustomer = 0, bool State = false)
        {
            this._Id = Id;
            this._Name = Name;
            this._Time = Time;
            this._IdTemplate = IdTemplate;
            this._IdCustomer = IdCustomer;
        }
        
        [DisplayName("#ID")]
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

        [DisplayName("Tên")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = Name;
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

        [Browsable(false)]
        public CTemplate Template
        {
            get
            {
                var Template = CApp.colTemplate.find(this._IdTemplate);
                return Template;
            }
            set
            {
                this._IdTemplate = Template.Id;
            }
        }
        public string TemplateName
        {
            get
            {
                var Template = CApp.colTemplate.find(this._IdTemplate);
                return Template.Name;
            }
            set
            {
                //this._IdCustomer = Customer.Id;
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

        [Browsable(false)]
        public CCustomer Customer
        {
            get
            {
                var Customer = CApp.colCustomer.find(this._IdCustomer);
                return Customer; 
            }
            set
            {
                this._IdCustomer = Customer.Id;
            }
        }
        public string CustomerName
        {
            get
            {
                var Customer = CApp.colCustomer.find(this._IdCustomer);
                return Customer.Name;
            }
            set
            {
                //this._IdCustomer = Customer.Id;
            }
        }

        [Browsable(false)]
        public bool State
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
            string UserState = "Testing ...";
            MailMessage message = this.Template.getMail();
            SmtpClient smtpClient = CApp.Sender._smtpClient;

            message.To.Add(this.Customer.Email);
            smtpClient.SendAsync(message, UserState);
        }

    }
    public class CollectionScheduler
    {
        private List<CScheduler> lstScheduler;

        public CollectionScheduler()
        {
            this.lstScheduler = new List<CScheduler>();
        }

        public List<CScheduler> getAll()
        {
            return this.lstScheduler;
        }

        public void Add(CScheduler Scheduler)
        {
            this.lstScheduler.Add(Scheduler);
        }

        public CScheduler find(int Id)
        {
            var qry = from t in CApp.colScheduler.getAll()
                      where t.Id == Id
                      select t;
            var lstScheduler = qry.ToList();
            if (lstScheduler.Count() == 0) return null;

            return lstScheduler[0];
        }

        public List<CScheduler> findAll()
        {
            var qry = from t in CApp.colScheduler.getAll()
                      where t.State == false
                      select t;
                        
            return qry.ToList();
        }

    }
}
