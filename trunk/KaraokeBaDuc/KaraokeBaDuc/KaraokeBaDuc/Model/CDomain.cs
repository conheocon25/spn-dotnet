using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeBaDuc
{
    class CDomain
    {
         private int     _Id;
        private string _Name;
        private DateTime _Time;
        private int _IdTemplate;
        private int _IdTag;
        private int _State;

        public CDomain(int Id = 0, string Name = "", DateTime Time = new DateTime(), int IdTemplate = 0, int IdTag = 0, int State = 0)
        {
            this._Id = Id;
            this._Name = Name;
            this._Time = Time;
            this._IdTemplate = IdTemplate;
            this._IdTag = IdTag;
            this._State = State;
        }
        
       
        public int Id
        {
            get{return this._Id;}
            set{this._Id = value ;}
        }

       
        public string Name
        {
            get{return this._Name;}
            set{this._Name = value;}
        }

       
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

       
        public string TemplateName
        {
            get{ return this.getTemplate().Name;}
            set{}
        }

        public int IdTag
        {
            get{return this._IdTag;}
            set{this._IdTag = value;}
        }

       
        public string TagName
        {
            get { return this.getTag().Name; }
            set { }
        }

       
        public int State
        {
            get { return this._State; }
            set { this._State = value; }
        }

        
        public string StatePrint
        {
            get { 
                if (this.State ==1)
                    return "Đã gửi";
                return "Chưa gửi";
            }
            set { }
        }
        
    }
}
