using QuanLyKhackSan.DataAcess;
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

namespace QuanLyKhachSan.GUI
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            string query = "SELECT * FROM dbo.STAFF WHERE IDCard = 1";
            DataSet ds = getData(query);
            DataTable dt = ds.Tables[0];
            txt_user.Text = dt.Rows[0]["UserName"].ToString();
            txt_Pass.Text = dt.Rows[0]["PassWord"].ToString();
            txt_Name.Text = dt.Rows[0]["DisplayName"].ToString();
            txt_adress.Text = dt.Rows[0]["Address"].ToString();
            txt_phonenumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
            txt_date.Text = dt.Rows[0]["DateOfBirth"].ToString();
            txt_sex.Text = dt.Rows[0]["Sex"].ToString();
            txt_startDay.Text = dt.Rows[0]["StartDay"].ToString();
        }
        private DataSet getData(string query)
        {   

            DataSet data = new DataSet();
            ConnectionString b = new ConnectionString();
            string con = b.getConnectionString(frmLogin.checkConnectionString);
            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, con);
                apter.Fill(data);
                connect.Close();
            }
            return data;
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
