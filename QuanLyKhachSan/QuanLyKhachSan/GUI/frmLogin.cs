using QuanLyKhackSan.DataAcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            checkLogin = 1;
            frmHome fh = new frmHome();
            this.Hide();
            fh.ShowDialog();
        
        }
    }
}
