using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace EmailMarketing
{
    public class CSchedulerMapper
    {
        //TRUY XUẤT CƠ SỞ DỮ LIỆU
        public IList<CScheduler> getAll()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_scheduler", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CScheduler> lst = dt.AsEnumerable().Select(row =>
                new CScheduler(
                    row.Field<int>("id"),                    
                    row.Field<DateTime>("time"),
                    row.Field<int>("id_template"),
                    row.Field<int>("id_customer"),
                    row.Field<int>("state")
                )
            ).ToList();
            return lst;
        }

        public IList<CScheduler> getAllReady()
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_scheduler WHERE state=0", CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CApp.close();

            IList<CScheduler> lst = dt.AsEnumerable().Select(row =>
                new CScheduler(
                    row.Field<int>("id"),
                    row.Field<DateTime>("time"),
                    row.Field<int>("id_template"),
                    row.Field<int>("id_customer"),
                    row.Field<int>("state")
                )
            ).ToList();
            return lst;
        }

        public CScheduler get(int Id)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_scheduler WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            CScheduler Tag = new CScheduler(
                dt.Rows[0].Field<int>("id"),                
                dt.Rows[0].Field<DateTime>("time"),
                dt.Rows[0].Field<int>("id_template"),
                dt.Rows[0].Field<int>("id_customer"),
                dt.Rows[0].Field<int>("state")
            );
            CApp.close();

            return Tag;
        }

        //CẬP NHẬT CƠ SỞ DỮ LIỆU
        public void insert(CScheduler Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_scheduler(time, id_template, id_customer, state) VALUES(@name, @time, @id_template, @id_customer, @state)", CApp.connection);            
            cmd.Parameters.AddWithValue("@time", Tag.Time);
            cmd.Parameters.AddWithValue("@id_template", Tag.IdTemplate);
            cmd.Parameters.AddWithValue("@id_customer", Tag.IdCustomer);
            cmd.Parameters.AddWithValue("@state", Tag.State);
            cmd.ExecuteNonQuery();
            CApp.close();
        }

        public void update(CScheduler Tag)
        {
            CApp.connect();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_scheduler SET time=@time, id_template=@id_template, id_tag=@id_tag  WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Tag.Id);
            cmd.Parameters.AddWithValue("@time", Tag.Time);
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

    }
}
