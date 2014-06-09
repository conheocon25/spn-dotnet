using System.Collections.Generic;

public class Customer { 
    private int _Id;
    private string _Name;
    private string _Email;
    private string _Phone;

    public Customer(int Id=0, string Name="", string Email="", string Phone="")
    {
        this._Id = Id;
        this._Name = Name;
        this._Email = Email;
        this._Phone = Phone;
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

public class CollectionCustomer {
    private List<Customer> lstCustomer;

    public CollectionCustomer() {
        this.lstCustomer = new List<Customer>();

        this.lstCustomer.Add( new Customer(1, "Tuấn", "tuanbuithanh@gmail.com", "0919 153 189") );
        this.lstCustomer.Add( new Customer(2, "Bảo", "thanhbao2007vl@gmail.com", "0903 062 068"));
        this.lstCustomer.Add( new Customer(3, "Toàn", "toanmkit@gmail.com", "0944 70 75 15"));
        this.lstCustomer.Add( new Customer(4, "Phương", "phanhoduyphuong@gmail.com", "0913 138 338"));
        this.lstCustomer.Add( new Customer(5, "Thạnh", "thanhlyvan@gmail.com", "0983 991239"));
        this.lstCustomer.Add( new Customer(6, "Vĩ", "truonglapvi@gmail.com", "0902 743218"));
        this.lstCustomer.Add( new Customer(7, "Trí", "trinm1987@gmail.com", "0946 124 142"));
    }

    public List<Customer> getAll()
    {
        return this.lstCustomer;
    }

}