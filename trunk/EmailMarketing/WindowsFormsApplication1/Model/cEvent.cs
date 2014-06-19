using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace EmailMarketing
{
    public class CEvent
    {
        private int     _Id;
        private string _Name;
        private DateTime _Time;
        private int _IdTemplate;
        private int _IdTag;
        private int _State;

        public CEvent(int Id = 0, string Name = "", DateTime Time = new DateTime(), int IdTemplate = 0, int IdTag = 0, int State = 0)
        {
            this._Id = Id;
            this._Name = Name;
            this._Time = Time;
            this._IdTemplate = IdTemplate;
            this._IdTag = IdTag;
            this._State = State;
        }
        
        [DisplayName("Id")]
        public int Id
        {
            get{return this._Id;}
            set{this._Id = value ;}
        }

        [DisplayName("Tên")]
        public string Name
        {
            get{return this._Name;}
            set{this._Name = value;}
        }

        [DisplayName("Thời điểm")]
        public DateTime Time
        {
            get{return this._Time;}
            set{this._Time = value;}
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
        
        [DisplayName("Mẫu thư")]
        public string TemplateName
        {
            get{ return this.getTemplate().Name;}
            set{}
        }

        [Browsable(false)]
        public int IdTag
        {
            get{return this._IdTag;}
            set{this._IdTag = value;}
        }

        [DisplayName("Nhóm")]
        public string TagName
        {
            get { return this.getTag().Name; }
            set { }
        }

        public CTag getTag()
        {
            var mTag = new CTagMapper();
            return mTag.get(this._IdTag);
        }

        [Browsable(false)]
        public int State
        {
            get { return this._State; }
            set { this._State = value; }
        }

        [DisplayName("Tình trạng")]
        public string StatePrint
        {
            get { 
                if (this.State ==1)
                    return "Đã gửi";
                return "Chưa gửi";
            }
            set { }
        }

        //Phát sinh ra các Scheduler
        public void generate() {
            var mScheduler = new CSchedulerMapper();
            var mCustomer = new CCustomerMapper();
            var CustomerAll = mCustomer.getByTag(this._IdTag);
            foreach (var Customer in CustomerAll)
            {
                mScheduler.insert(
                    new CScheduler(
                        1,
                        this.Time,
                        this.IdTemplate,
                        Customer.Id,
                        0
                        )
                );
            }
        }
    }
}
