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

        public CEvent(int Id = 0, string Name = "", DateTime Time = new DateTime(), int IdTemplate = 0, int IdTag = 0)
        {
            this._Id = Id;
            this._Name = Name;
            this._Time = Time;
            this._IdTemplate = IdTemplate;
            this._IdTag = IdTag;
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
        
        [DisplayName("Mẫu thư")]
        public string TemplateName
        {
            get{ return this.getTemplate().Name;}
            set{}
        }
                       

        [Browsable(false)]
        public int IdTag
        {
            get
            {
                return this._IdTag;
            }
            set
            {
                this._IdTag = IdTag;
            }
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

    }    
}
