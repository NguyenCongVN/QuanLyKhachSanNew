using QuanLyKhackSan.DataAcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frmLogin : Form
    {
        internal static int checkConnectionString;
        internal static int checkLogin;
        public frmLogin()
        {
            InitializeComponent();
            Thread threadCheckConnect = new Thread(check);
            threadCheckConnect.Start();
        }
        public void check()
        {
            ConnectionString check = new ConnectionString();
            checkConnectionString = check.checkCnn();
        }
        private void btn_Login_Click_1(object sender, EventArgs e)
        {

            string username = txt_user.Text;
            string pass = txt_pass.Text;
            if (username == "" || pass == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {

                if (checkAccount(username, pass) == 1)
                {


                    frmHome a = new frmHome();
                    this.Hide();
                    a.ShowDialog();
                    this.Close();
                }

                else MessageBox.Show("Lỗi . Mật khẩu không đúng");
            }

            
        
        }
        private DataTable connectionTable()
        {
            DataTable data = new DataTable();
            // create datatable connect database Users
            string query = "SELECT UserName,PassWord FROM staff";
            ConnectionString cnn = new ConnectionString();
            string con = cnn.getConnectionString(frmLogin.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }
        private int checkAccount(string name, string pass)
        {
            DataTable data = connectionTable();
            for (int i = 0; i < data.Rows.Count; i++)
            {

                string tempName = data.Rows[i]["UserName"].ToString().Trim();
                string tempPass = data.Rows[i]["PassWord"].ToString().Trim();
                //  tempPass = tempPass.Trim();
                //  tempName = tempName.Trim();
                //  MessageBox.Show(tempPass + tempName);

                if (name.Equals(tempName))
                {

                    if (pass.Equals(tempPass))
                    {
                        return 1;
                    }

                }

            }
            return 0;
        }
    }
}
