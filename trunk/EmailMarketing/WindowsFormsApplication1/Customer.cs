using System.Collections.Generic;

public class Customer { 
    public int Id;
    public string Name;
    public string Email;
    public string Phone;

    public Customer(int Id_=0, string Name_="", string Email_="", string Phone_="") {
        this.Id = Id_;
        this.Name = Name_;
        this.Email = Email_;
        this.Phone = Phone_;
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

}