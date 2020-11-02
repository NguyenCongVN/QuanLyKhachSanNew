using QuanLyKhackSan.DataAcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frmManagerialCustomer : Form
    {
        public static string IDcart;
        public frmManagerialCustomer()
        {
            InitializeComponent();
            showdata();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void showdata()
        {
            string query = "  SELECT IDCard AS 'Số CMND', Name AS 'Họ tên',DateOfBirth AS 'Ngày sinh',Sex AS 'Giới tính', Address AS 'Địa chỉ',Nationality AS' Quốc tịch' FROM dbo.CUSTOMER";
            DataSet data = new DataSet();
            // create datatable connect database Users
            ConnectionString cnn = new ConnectionString();
            string con = cnn.getConnectionString(frmLogin.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            showDataRoom.DataSource = data.Tables[0];
        }

        private void showDataRoom_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posClicked;
            posClicked = showDataRoom.SelectedRows[0].Index;
            DataGridViewRow temp = this.showDataRoom.Rows[posClicked];
            string Ma = temp.Cells[0].Value.ToString();
            frmManagerialCustomer.IDcart = Ma;
            show();
        }
        private DataTable connectionTable(string maCart)
        {
            DataTable data = new DataTable();
            // create datatable connect database Users
            string query = "SELECT * FROM dbo.CUSTOMER WHERE IDCard='" + maCart + "'";
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
        public void show()
        {

            DataTable data = connectionTable(frmManagerialCustomer.IDcart);
            makhachhang.Text = data.Rows[0]["ID"].ToString();
            Name.Text = data.Rows[0]["Name"].ToString();
            DateTime date;
            string gioitinh = data.Rows[0]["Sex"].ToString();
            if (gioitinh == "Nam")
            {
                Nam.Checked = true;
                nu.Checked = false;
            }
            else
            {
                Nam.Checked = false;
                nu.Checked = true;
            }
            Sdt.Text= data.Rows[0]["PhoneNumber"].ToString();
            diachi.Text = data.Rows[0]["Address"].ToString();
            CMND.Text = data.Rows[0]["IDCard"].ToString();
            quoctich.Text = data.Rows[0]["Nationality"].ToString();
          
            string temp = data.Rows[0]["DateOfBirth"].ToString();
            int n = temp.Length - 1;
            int n2 = temp.IndexOf(" ");
            string temp1 = temp.Substring(0,n2);
            ngaysinh_kh.Value= DateTime.ParseExact(temp1, "M/d/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
