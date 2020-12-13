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
        public static string MaNhanVien;
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
            var query = @"SELECT COUNT(*) FROM dbo.STAFF
            WHERE UserName = @userName AND PassWord = @passWord";
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query , connection);
                cmd.Parameters.AddWithValue("@userName", txt_user.Text);
                cmd.Parameters.AddWithValue("@passWord", txt_pass.Text);
                checkLogin = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (checkLogin > 0)
                {
                    MaNhanVien = txt_user.Text;
                    frmHome fh = new frmHome();
                    this.Hide();
                    fh.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại!");
                }
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            //duy change
            Application.Exit();
        }
    }
}
