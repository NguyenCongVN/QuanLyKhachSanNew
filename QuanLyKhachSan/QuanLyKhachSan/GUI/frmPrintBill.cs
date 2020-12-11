using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frmPrintBill : Form
    {
        public frmPrintBill()
        {
            listView1.Columns.Add("STT", 50);
            listView1.Columns.Add("Tên dịch vụ", 100);
            listView1.Columns.Add("Đơn giá", 50);
            listView1.Columns.Add("Số lượng", 50);
            listView1.Columns.Add("Thành tiền", 50);
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
