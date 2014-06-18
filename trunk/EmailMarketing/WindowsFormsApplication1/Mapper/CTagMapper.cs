using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public class CTagMapper
    {
        //TRUY XUẤT CƠ SỞ DỮ LIỆU
        public IList<CTag> getAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_tag", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CTag> lstTag = dt.AsEnumerable().Select(row =>
                new CTag(row.Field<int>("id"), row.Field<string>("name"))
            ).ToList();
            return lstTag;
        }

        public CTag get(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_tag WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CTag Tag = new CTag(dt.Rows[0].Field<int>("id"), dt.Rows[0].Field<string>("name"));
            CApp.close();

            return Tag;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CTag Tag) {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_tag(name) VALUES(@name)", CApp.connection);
            cmd.Parameters.AddWithValue("@name", Tag.Name);            
            cmd.ExecuteNonQuery();
            CApp.close();

        }

        public void update(CTag Tag)
        {
            CApp.connect();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_tag SET name=@name  WHERE id=@id", CApp.connection);
            cmdUpdate.Parameters.AddWithValue("@id", Tag.Id);
            cmdUpdate.Parameters.AddWithValue("@name", Tag.Name);
            cmdUpdate.ExecuteNonQuery();
            CApp.close();
        }

        public void delete(int Id) {
            CApp.connect();            
            SqlCommand cmd = new SqlCommand("DELETE FROM  tbl_tag WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

    }
}
