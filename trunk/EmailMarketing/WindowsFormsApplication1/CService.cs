using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmailMarketing
{
    public static class CService
    {
        public static void updateGrid(DataGridView dgv, string strSQL)
        {
            CApp.connect();
            
            SqlCommand cmd = new SqlCommand(strSQL, CApp.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgv.DataSource = dt;

            CApp.close();              
        }

        public static void deleteById(string strName, int Id) {
            CApp.connect();
            
            SqlCommand cmd = new SqlCommand("DELETE FROM " + strName + " WHERE id=@id", CApp.connection);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();

            CApp.close();
        }
    }
}
