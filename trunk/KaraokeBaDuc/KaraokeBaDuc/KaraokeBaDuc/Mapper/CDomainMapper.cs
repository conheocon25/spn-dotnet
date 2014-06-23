using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KaraokeBaDuc
{
    class CDomainMapper
    {
        public IList<CDomain> getAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_event", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CDomain> lstTag = dt.AsEnumerable().Select(row =>
                new CDomain(
                    row.Field<int>("id"),
                    row.Field<string>("name"),
                    row.Field<DateTime>("time"),
                    row.Field<int>("id_template"),
                    row.Field<int>("id_tag"),
                    row.Field<int>("state")
                )
            ).ToList();
            return lstTag;
        }

        public IList<CDomain> getAllReady()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_event WHERE DATEDIFF(day, GETDATE(), [time])=0 AND state=0", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CDomain> lstTag = dt.AsEnumerable().Select(row =>
                new CDomain(
                    row.Field<int>("id"),
                    row.Field<string>("name"),
                    row.Field<DateTime>("time"),
                    row.Field<int>("id_template"),
                    row.Field<int>("id_tag"),
                    row.Field<int>("state")
                )
            ).ToList();
            return lstTag;
        }

        public CDomain get(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_event WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CDomain Tag = new CDomain(
                dt.Rows[0].Field<int>("id"),
                dt.Rows[0].Field<string>("name"),
                dt.Rows[0].Field<DateTime>("time"),
                dt.Rows[0].Field<int>("id_template"),
                dt.Rows[0].Field<int>("id_tag"),
                dt.Rows[0].Field<int>("state")
            );
            CApp.close();

            return Tag;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CDomain Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_event(name, time, id_template, id_tag, state) VALUES(@name, @time, @id_template, @id_tag)", CApp.connection);
            cmd.Parameters.AddWithValue("@name", Tag.Name);
            cmd.Parameters.AddWithValue("@time", Tag.Time);
            cmd.Parameters.AddWithValue("@id_template", Tag.IdTemplate);
            cmd.Parameters.AddWithValue("@id_tag", Tag.IdTag);
            cmd.Parameters.AddWithValue("@state", Tag.State);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void update(CDomain Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_event SET name=@name, time=@time, id_template=@id_template, id_tag=@id_tag, state=@state  WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Tag.Id);
            cmd.Parameters.AddWithValue("@name", Tag.Name);
            cmd.Parameters.AddWithValue("@time", Tag.Time);
            cmd.Parameters.AddWithValue("@id_template", Tag.IdTemplate);
            cmd.Parameters.AddWithValue("@id_tag", Tag.IdTag);
            cmd.Parameters.AddWithValue("@state", Tag.State);
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
