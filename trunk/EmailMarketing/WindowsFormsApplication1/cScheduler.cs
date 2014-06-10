using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketing
{
    public class CScheduler
    {        
        private int _Id;
        private string _Name;
        private DateTime _Time;
        private int _IdTemplate;
        private int _IdCustomer;

        public CScheduler(int Id = 0, string Name = "", DateTime Time = new DateTime(), int IdTemplate = 0, int IdCustomer = 0)
        {
            this._Id = Id;
            this._Name = Name;
            this._Time = Time;
            this._IdTemplate = IdTemplate;
            this._IdCustomer = IdCustomer;
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
        
    }
    public class CollectionScheduler
    {
        private List<CScheduler> lstScheduler;

        public CollectionScheduler()
        {
            this.lstScheduler = new List<CScheduler>();

            //this.lstScheduler.Add(new CScheduler(1, "Sự kiện mùa hè", "1/6/2014", "15/6/2014", "Sự kiện dành cho mùa hè"));
            //this.lstScheduler.Add(new CScheduler(2, "Sự kiện mùa thu", "1/9/2014", "15/9/2014", "Sự kiện dành cho mùa thu"));
            //this.lstScheduler.Add(new CScheduler(3, "Sự kiện mùa đông", "1/12/2014", "15/12/2014", "Sự kiện dành cho mùa đông"));
        }

        public List<CScheduler> getAll()
        {
            return this.lstScheduler;
        }

        public void Add(CScheduler Scheduler)
        {
            this.lstScheduler.Add(Scheduler);
        }

    }
}
