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
            Connect();
            string sql = "SELECT * FROM tbl_customer";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Authors_table");
            conn.Close();
            dtgCustomer.DataSource = ds;
            dtgCustomer.DataMember = "Authors_table";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Connect();
                string sql = "INSERT INTO tbl_customer VALUES('" + txtID.Text + "','" + txtName.Text + "','" + txtGender.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                initData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Connect();
                string sql = "UPDATE tbl_customer SET name='" + txtName.Text + "', gender='" + txtGender.Text + "', email='" + txtEmail.Text + "', phone='" + txtPhone.Text + "', address='" + txtAddress.Text + "' WHERE id='" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                initData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Connect();
                string sql = "DELETE FROM tbl_customer WHERE id='" + txtID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                initData();
            }
        }

    }
}
