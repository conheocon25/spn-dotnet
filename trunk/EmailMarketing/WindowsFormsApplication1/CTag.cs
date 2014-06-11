using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketing
{
    public class CTag
    {
        private int _Id;
        private string _Name;
        
        public CTag(int Id = 0, string Name = "")
        {
            this._Id = Id;
            this._Name = Name;            
        }

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

    }

    public class CollectionTag
    {
        private List<CTag> lstTag;

        public CollectionTag()
        {
            this.lstTag = new List<CTag>();

            this.lstTag.Add(new CTag(1, "Quần áo"));
            this.lstTag.Add(new CTag(2, "Giày dép"));
            this.lstTag.Add(new CTag(3, "Thú cưng"));
        }

        public List<CTag> getAll()
        {
            return this.lstTag;
        }

        public void Add(CTag Cus)
        {
            this.lstTag.Add(Cus);
        }
        
        public CTag find(int Id) {
            var qryTag = from t in CApp.colTag.getAll()
                              where t.Id == Id
                              select t;
            var lstTag = qryTag.ToList();
            if (lstTag.Count() == 0) return null;

            return lstTag[0];
        }
    }
}
