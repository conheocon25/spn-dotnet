using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketing
{
    public class CScheduler
    {
        private int     _Id;
        private string _Name;
        private string _DateFrom;
        private string _DateTo;
        private string _Note;

        public CScheduler(int Id = 0, string Name = "", string DateFrom = "", string DateTo = "", string Note = "")
        {
            this._Id = Id;
            this._Name = Name;
            this._DateFrom = DateFrom;
            this._DateTo = DateTo;
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

        public string DateFrom
        {
            get
            {
                return this._DateFrom;
            }
            set
            {
                this._DateFrom = DateFrom;
            }
        }

        public string DateTo
        {
            get
            {
                return this._DateTo;
            }
            set
            {
                this._DateTo = DateTo;
            }
        }

        public string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this._Note = Note;
            }
        }
    }
    public class CollectionScheduler
    {
        private List<CScheduler> lstScheduler;

        public CollectionScheduler()
        {
            this.lstScheduler = new List<CScheduler>();

            this.lstScheduler.Add(new CScheduler(1, "Sự kiện mùa hè", "1/6/2014", "15/6/2014", "Sự kiện dành cho mùa hè"));
            this.lstScheduler.Add(new CScheduler(2, "Sự kiện mùa thu", "1/9/2014", "15/9/2014", "Sự kiện dành cho mùa thu"));
            this.lstScheduler.Add(new CScheduler(3, "Sự kiện mùa đông", "1/12/2014", "15/12/2014", "Sự kiện dành cho mùa đông"));
        }

        public List<CScheduler> getAll()
        {
            return this.lstScheduler;
        }

    }
}
