using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

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

    }
}
