using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public class CEventMapper
    {
        //TRUY XUẤT CƠ SỞ DỮ LIỆU
        public IList<CEvent> getAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_event", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CEvent> lstTag = dt.AsEnumerable().Select(row =>
                new CEvent(
                    row.Field<int>("id"),
                    row.Field<string>("name"),
                    row.Field<DateTime>("time"), 
                    row.Field<int>("id_template"),
                    row.Field<int>("id_tag")
                )
            ).ToList();
            return lstTag;
        }

        public CEvent get(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_event WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CEvent Tag = new CEvent(
                dt.Rows[0].Field<int>("id"), 
                dt.Rows[0].Field<string>("name"),
                dt.Rows[0].Field<DateTime>("time"),
                dt.Rows[0].Field<int>("id_template"),
                dt.Rows[0].Field<int>("id_tag")
            );
            CApp.close();

            return Tag;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CEvent Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_event(name, time, id_template, id_tag) VALUES(@name, @time, @id_template, @id_tag)", CApp.connection);
            cmd.Parameters.AddWithValue("@name", Tag.Name);
            cmd.Parameters.AddWithValue("@time", Tag.Time);
            cmd.Parameters.AddWithValue("@id_template", Tag.IdTemplate);
            cmd.Parameters.AddWithValue("@id_tag", Tag.IdTag);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void update(CEvent Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_event SET name=@name, time=@time, id_template=@id_template, id_tag=@id_tag  WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Tag.Id);
            cmd.Parameters.AddWithValue("@name", Tag.Name);
            cmd.Parameters.AddWithValue("@time", Tag.Time);
            cmd.Parameters.AddWithValue("@id_template", Tag.IdTemplate);
            cmd.Parameters.AddWithValue("@id_tag", Tag.IdTag);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void delete(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM  tbl_event WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

    }
}
