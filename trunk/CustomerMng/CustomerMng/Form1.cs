using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMng
{
    public partial class FCustomer : Form
    {
        private SqlConnection conn;

        public FCustomer()
        {
            InitializeComponent();
            initData();
        }

        public void initData()
        {
            /*
            dtgCustomer.ColumnCount = 6;
            dtgCustomer.Columns[0].Name = "ID";
            dtgCustomer.Columns[1].Name = "Họ và Tên";
            dtgCustomer.Columns[2].Name = "Giới tính";
            dtgCustomer.Columns[3].Name = "Email";
            dtgCustomer.Columns[4].Name = "Điện thoại";
            dtgCustomer.Columns[5].Name = "Địa chỉ";
            */
            Connect();

            string sql = "SELECT * FROM tbl_customer";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Authors_table");
            conn.Close();
            dtgCustomer.DataSource = ds;
            dtgCustomer.DataMember = "Authors_table";

            //dtgCustomer.Rows.Add(new string[] { "1", "Tuấn Bùi Thanh", "Nam", "tuanbuithanh@gmail.com", "0123456789", "Châu Thành - Đồng Tháp" });
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgCustomer.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtName.Text = dtgCustomer.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtGender.Text = dtgCustomer.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            txtEmail.Text = dtgCustomer.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtPhone.Text = dtgCustomer.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            txtAddress.Text = dtgCustomer.Rows[e.RowIndex].Cells["address"].Value.ToString();
        }

        public void Connect()
        {
            string strConnect = "Data Source= .\\SQLEXPRESS;Initial catalog=db_customer;Integrated security=SSPI;Application Name=True";
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
