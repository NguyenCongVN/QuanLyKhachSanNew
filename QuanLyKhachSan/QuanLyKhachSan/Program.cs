using QuanLyKhachSan.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhackSan.DataAcess;

namespace QuanLyKhachSan
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ConnectionString ConnectionString = new ConnectionString();

        public static frmLogin frmLogin;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new frmLogin();
            Application.Run(frmLogin);
        }
    }
}
