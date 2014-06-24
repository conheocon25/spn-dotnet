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


        public CDomain(int Id = 0, string Name = "")
        {
            this._Id = Id;
            this._Name = Name;            
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
    }
}
