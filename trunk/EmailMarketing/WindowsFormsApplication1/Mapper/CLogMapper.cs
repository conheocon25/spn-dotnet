using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public class CLogMapper
    {
        //TRUY XUẤT CƠ SỞ DỮ LIỆU
        public IList<CLog> getAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_log ORDER BY time_end DESC", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CLog> lst = dt.AsEnumerable().Select(row =>
                new CLog(
                    row.Field<int>("id"),
                    row.Field<DateTime>("time_start"),
                    row.Field<DateTime>("time_end"),
                    row.Field<int>("id_template"),
                    row.Field<int>("id_customer"),
                    row.Field<int>("state")
                )
            ).ToList();
            return lst;
        }

        public IList<CLog> getAllReady()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_log WHERE state=0", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CLog> lst = dt.AsEnumerable().Select(row =>
                new CLog(
                    row.Field<int>("id"),
                    row.Field<DateTime>("time_start"),
                    row.Field<DateTime>("time_end"),
                    row.Field<int>("id_template"),
                    row.Field<int>("id_customer"),
                    row.Field<int>("state")
                )
            ).ToList();
            return lst;
        }

        public CLog get(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_log WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CLog Tag = new CLog(
                dt.Rows[0].Field<int>("id"),
                dt.Rows[0].Field<DateTime>("time"),
                dt.Rows[0].Field<DateTime>("id_template"),
                dt.Rows[0].Field<int>("id_customer"),
                dt.Rows[0].Field<int>("state")
            );
            CApp.close();

            return Tag;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CLog Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_log(time_start, time_end, id_template, id_customer, state) VALUES(@time_start, @time_end, @id_template, @id_customer, @state)", CApp.connection);
            cmd.Parameters.AddWithValue("@time_start", Tag.TimeStart);
            cmd.Parameters.AddWithValue("@time_end", Tag.TimeEnd);
            cmd.Parameters.AddWithValue("@id_template", Tag.IdTemplate);
            cmd.Parameters.AddWithValue("@id_customer", Tag.IdCustomer);
            cmd.Parameters.AddWithValue("@state", Tag.State);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void update(CLog Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_log SET time_start=@time_start, time_end=@time_end, id_template=@id_template, id_tag=@id_tag  WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Tag.Id);
            cmd.Parameters.AddWithValue("@time_start", Tag.TimeStart);
            cmd.Parameters.AddWithValue("@time_end", Tag.TimeEnd);
            cmd.Parameters.AddWithValue("@id_template", Tag.IdTemplate);
            cmd.Parameters.AddWithValue("@id_customer", Tag.IdCustomer);
            cmd.Parameters.AddWithValue("@state", Tag.State);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void delete(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM  tbl_scheduler WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void deleteAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("DELETE FROM  tbl_scheduler", CApp.connection);
            cmd.ExecuteNonQuery();
            CApp.close();
        }
    }
}
