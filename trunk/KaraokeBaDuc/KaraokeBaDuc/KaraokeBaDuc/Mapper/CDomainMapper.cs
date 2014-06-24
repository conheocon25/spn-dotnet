using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KaraokeBaDuc
{
    class CDomainMapper
    {
        public IList<CDomain> getAll()
        {
            CApp.Connect();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM k3d_domain", CApp.MySQLConnection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.Close();

            IList<CDomain> lstTag = dt.AsEnumerable().Select(row =>
                new CDomain(
                    row.Field<int>("id"),
                    row.Field<string>("name")                   
                )
            ).ToList();
            return lstTag;
        }

        public IList<CDomain> getAllReady()
        {
            CApp.Connect();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM k3d_domain", CApp.MySQLConnection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.Close();

            IList<CDomain> lstDomain = dt.AsEnumerable().Select(row =>
                new CDomain(
                    row.Field<int>("id"),
                    row.Field<string>("name")
                )
            ).ToList();
            return lstDomain;
        }

        public CDomain get(int Id)
        {
            CApp.Connect();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM k3d_domain WHERE id=@id", CApp.MySQLConnection);
            cmd.Parameters.AddWithValue("@id", Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CDomain LstDomain = new CDomain(
                dt.Rows[0].Field<int>("id"),
                dt.Rows[0].Field<string>("name")
            );
            CApp.Close();

            return LstDomain;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CDomain Tag)
        {
            CApp.Connect();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO k3d_domain(name) VALUES(@name)", CApp.MySQLConnection);
            cmd.Parameters.AddWithValue("@name", Tag.Name);            
            cmd.ExecuteNonQuery();
            CApp.Close();
        }

        public void update(CDomain Tag)
        {
            CApp.Connect();
            MySqlCommand cmd = new MySqlCommand("UPDATE k3d_domain SET name=@name  WHERE id=@id", CApp.MySQLConnection);
            cmd.Parameters.AddWithValue("@id", Tag.Id);
            cmd.Parameters.AddWithValue("@name", Tag.Name);
            cmd.ExecuteNonQuery();
            CApp.Close();
        }

        public void delete(int Id)
        {
            CApp.Connect();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM  k3d_domain WHERE id=@id", CApp.MySQLConnection);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            CApp.Close();
        }
           
    }
}
