using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public class CCustomerMapper
    {
        //TRUY XUẤT CƠ SỞ DỮ LIỆU
        public IList<CCustomer> getAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_customer", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CCustomer> lstCustomer = dt.AsEnumerable().Select(row =>
                new CCustomer(
                        row.Field<int>("id"),
                        row.Field<int>("id_tag"), 
                        row.Field<string>("name"),
                        row.Field<string>("email"), 
                        row.Field<string>("phone")
                )
            ).ToList();
            return lstCustomer;
        }
        public IList<CCustomer> getByTag(int IdTag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_customer WHERE id_tag=@id_tag", CApp.connection);
            cmd.Parameters.AddWithValue("@id_tag", IdTag);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CCustomer> lstCustomer = dt.AsEnumerable().Select(row =>
                new CCustomer(
                        row.Field<int>("id"),
                        row.Field<int>("id_tag"),
                        row.Field<string>("name"),
                        row.Field<string>("email"),
                        row.Field<string>("phone")
                )
            ).ToList();
            return lstCustomer;
        }
        public CCustomer get(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_customer WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CCustomer Customer = new CCustomer(
                dt.Rows[0].Field<int>("id"),
                dt.Rows[0].Field<int>("id_tag"), 
                dt.Rows[0].Field<string>("name"),
                dt.Rows[0].Field<string>("email"),
                dt.Rows[0].Field<string>("phone")
            );
            CApp.close();

            return Customer;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CCustomer Customer)
        {
            CApp.connect();
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_customer(id_tag, name, email, phone) VALUES(@id_tag, @name, @email, @phone)", CApp.connection);
            cmdInsert.Parameters.AddWithValue("@id_tag", Customer.IdTag);
            cmdInsert.Parameters.AddWithValue("@name", Customer.Name);
            cmdInsert.Parameters.AddWithValue("@email", Customer.Email);
            cmdInsert.Parameters.AddWithValue("@phone", Customer.Phone);
            cmdInsert.ExecuteNonQuery();
            CApp.close();
        }
        public void update(CCustomer Customer)
        {
            CApp.connect();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_customer SET id_tag=@id_tag, name=@name, email=@email, phone=@phone  WHERE id=@id", CApp.connection);
            cmdUpdate.Parameters.AddWithValue("@id", Customer.Id);
            cmdUpdate.Parameters.AddWithValue("@id_tag", Customer.IdTag);
            cmdUpdate.Parameters.AddWithValue("@name", Customer.Name);
            cmdUpdate.Parameters.AddWithValue("@email", Customer.Email);
            cmdUpdate.Parameters.AddWithValue("@phone", Customer.Phone);
            cmdUpdate.ExecuteNonQuery();
            CApp.close();
        }
        public void delete(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM  tbl_customer WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            CApp.close();
        }
    }
}
