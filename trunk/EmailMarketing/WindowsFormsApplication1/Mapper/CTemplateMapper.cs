using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public class CTemplateMapper
    {
        //TRUY XUẤT CƠ SỞ DỮ LIỆU
        public IList<CTemplate> getAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_template", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CTemplate> lstTemplate = dt.AsEnumerable().Select(row =>
                new CTemplate(
                    row.Field<int>("id"), 
                    row.Field<string>("name"),
                    row.Field<string>("content")
                )
            ).ToList();
            return lstTemplate;
        }

        public CTemplate get(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_template WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CTemplate Template = new CTemplate(
                dt.Rows[0].Field<int>("id"), 
                dt.Rows[0].Field<string>("name"),
                dt.Rows[0].Field<string>("content")
            );
            CApp.close();

            return Template;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CTemplate Template)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_template(name, content) VALUES(@name, @content)", CApp.connection);
            cmd.Parameters.AddWithValue("@name", Template.Name);
            cmd.Parameters.AddWithValue("@content", Template.Content);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void update(CTemplate Template)
        {
            CApp.connect();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_template SET name=@name, content=@content  WHERE id=@id", CApp.connection);
            cmdUpdate.Parameters.AddWithValue("@id", Template.Id);
            cmdUpdate.Parameters.AddWithValue("@name", Template.Name);
            cmdUpdate.Parameters.AddWithValue("@content", Template.Content);
            cmdUpdate.ExecuteNonQuery();
            CApp.close();
        }

        public void delete(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM  tbl_template WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

    }
}
