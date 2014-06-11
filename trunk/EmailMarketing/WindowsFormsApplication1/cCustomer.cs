using System.ComponentModel;
using System.Collections.Generic;

namespace EmailMarketing
{
    public class CCustomer
    {
        private int _Id;
        private int _IdTag;
        private string _Name;
        private string _Email;
        private string _Phone;

        public CCustomer(int Id = 0, int IdTag = 0,  string Name = "", string Email = "", string Phone = "")
        {
            this._Id = Id;
            this._IdTag = IdTag;
            this._Name = Name;
            this._Email = Email;
            this._Phone = Phone;
        }

        [DisplayName("#ID")]
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
        
        [Browsable(false)]
        public CTag Tag
        {
            get
            {                
                var Tag = CApp.colTag.find(this._IdTag);
                return Tag;
            }
            set
            {
                this._IdTag = Tag.Id;
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

    public class CollectionCustomer
    {
        private List<CCustomer> lstCustomer;

        public CollectionCustomer()
        {
            this.lstCustomer = new List<CCustomer>();

            this.lstCustomer.Add(new CCustomer(1, 1, "Tuấn", "tuanbuithanh@gmail.com", "0919 153 189"));
            this.lstCustomer.Add(new CCustomer(2, 1, "Bảo", "thanhbao2007vl@gmail.com", "0903 062 068"));
            this.lstCustomer.Add(new CCustomer(3, 2, "Toàn", "toanmkit@gmail.com", "0944 70 75 15"));
            this.lstCustomer.Add(new CCustomer(4, 2, "Phương", "phanhoduyphuong@gmail.com", "0913 138 338"));
            this.lstCustomer.Add(new CCustomer(5, 3, "Thạnh", "thanhlyvan@gmail.com", "0983 991239"));
            this.lstCustomer.Add(new CCustomer(6, 3, "Vĩ", "truonglapvi@gmail.com", "0902 743218"));
            this.lstCustomer.Add(new CCustomer(7, 3, "Trí", "trinm1987@gmail.com", "0946 124 142"));
        }

        public List<CCustomer> getAll()
        {
            return this.lstCustomer;
        }

        public void Add(CCustomer Cus)
        {
            this.lstCustomer.Add(Cus);
        }
    }
}
