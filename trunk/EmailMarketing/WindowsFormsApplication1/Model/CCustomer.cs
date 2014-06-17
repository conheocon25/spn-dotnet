using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace EmailMarketing
{
    public class CCustomer
    {
        private int _Id;
        private int _IdTag;
        private string _Name;
        private string _Email;
        private string _Phone;

        public CCustomer(int Id = 0, int IdTag = 0, string Name = "", string Email = "", string Phone = "")
        {
            this._Id = Id;
            this._IdTag = IdTag;
            this._Name = Name;
            this._Email = Email;
            this._Phone = Phone;
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
                        
        [DisplayName("Tên KH")]
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

        [DisplayName("Email")]
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = Email;
            }
        }

        [DisplayName("Điện thoại")]
        public string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this._Phone = Phone;
            }
        }

    }
}
