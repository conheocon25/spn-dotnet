using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net.Mail;
using System.Net;

namespace EmailMarketing
{
    public class CLog
    {
        private int _Id;
        private DateTime _TimeStart;
        private DateTime _TimeEnd;
        private int _IdTemplate;
        private int _IdCustomer;
        private int _State;

        public CLog(int Id = 0, DateTime TimeStart = new DateTime(), DateTime TimeEnd = new DateTime(), int IdTemplate = 0, int IdCustomer = 0, int State = 0)
        {
            this._Id = Id;
            this._TimeStart = TimeStart;
            this._TimeEnd = TimeEnd;
            this._IdTemplate = IdTemplate;
            this._IdCustomer = IdCustomer;
            this._State = State;
        }

        [DisplayName("Id")]
        public int Id
        {
            get{return this._Id;}
            set{this._Id = value;}
        }

        [Browsable(false)]
        public int IdTemplate
        {
            get{return this._IdTemplate;}
            set{this._IdTemplate = value;}
        }

        public CTemplate getTemplate()
        {
            var mTemplate = new CTemplateMapper();
            return mTemplate.get(this._IdTemplate);
        }

        [DisplayName("Thời điểm 1")]
        public DateTime TimeStart
        {
            get{return this._TimeStart;}
            set{this._TimeStart = value;}
        }

        [DisplayName("Thời điểm 2")]
        public DateTime TimeEnd
        {
            get { return this._TimeEnd; }
            set { this._TimeEnd = value; }
        }

        [DisplayName("Mẫu thư")]
        public string TemplateName
        {
            get { return this.getTemplate().Name; }
            set { }
        }

        [Browsable(false)]
        public int IdCustomer
        {
            get{return this._IdCustomer;}
            set{this._IdCustomer = value;}
        }

        [DisplayName("Khách hàng")]
        public string CustomerName
        {
            get { return this.getCustomer().Name; }
            set { }
        }

        public CCustomer getCustomer()
        {
            var mCustomer = new CCustomerMapper();
            return mCustomer.get(this._IdCustomer);
        }

        [Browsable(false)]
        public int State
        {
            get{return this._State;}
            set{this._State = value;}
        }

        [DisplayName("Trạng  thái")]
        public string StatePrint
        {
            get { return this.State == 1 ? "Đã gửi" : "Chưa gửi"; }
            set { }
        }
                
    }
}
