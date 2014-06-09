using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMarketing
{
    public class Event
    {
        private int     _Id;
        private string _Name;
        private string _DateFrom;
        private string _DateTo;
        private string _Note;

        public Event(int Id = 0, string Name = "", string DateFrom = "", string DateTo = "",  string Note = "")
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

    public class CollectionEvent
    {
        private List<Event> lstEvent;

        public CollectionEvent()
        {
            this.lstEvent = new List<Event>();

            this.lstEvent.Add(new Event(1, "Sự kiện mùa hè", "1/6/2014", "15/6/2014", "Sự kiện dành cho mùa hè"));
            this.lstEvent.Add(new Event(2, "Sự kiện mùa thu", "1/9/2014", "15/9/2014", "Sự kiện dành cho mùa thu"));
            this.lstEvent.Add(new Event(3, "Sự kiện mùa đông", "1/12/2014", "15/12/2014", "Sự kiện dành cho mùa đông"));
        }

        public List<Event> getAll()
        {
            return this.lstEvent;
        }

    }
}
