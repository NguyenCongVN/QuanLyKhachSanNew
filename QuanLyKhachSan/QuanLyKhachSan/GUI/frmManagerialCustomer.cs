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
            diachi.Text = data.Rows[0]["Address"].ToString();
            CMND.Text = data.Rows[0]["IDCard"].ToString();
            quoctich.Text = data.Rows[0]["Nationality"].ToString();
            ngaysinh.Text = data.Rows[0]["DateOfBirth"].ToString();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string hoTen = Name.Text;
            string cmnd = CMND.Text;
            string diaChi = diachi.Text;
            string quocTich = quoctich.Text;
            int maKhachHang = Int32.Parse(makhachhang.Text);
            DateTime ngaySinh;
            try
            {
                ngaySinh = DateTime.Parse(ngaysinh.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hãy Nhập Đúng Định Dạng");
                return;
            }

            string gioiTinh = string.Empty;
            if (Nam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            var query = @"UPDATE dbo.CUSTOMER
SET IDCard = @cmnd,
Name = @tenKhachHang,
DateOfBirth = @ngaySinh,
Address = @diaChi,
Sex = @gioiTinh,
Nationality = @quocTich
WHERE ID = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@cmnd", cmnd);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@tenKhachHang", hoTen);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@quocTich", quocTich);
                    cmd.Parameters.AddWithValue("@id", maKhachHang);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Thành Công");
                    showdata();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string hoTen = Name.Text;
            string cmnd = CMND.Text;
            string diaChi = diachi.Text;
            string quocTich = quoctich.Text;
            DateTime ngaySinh;
            try
            {
                ngaySinh = DateTime.Parse(ngaysinh.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hãy Nhập Đúng Định Dạng");
                return;
            }

            string gioiTinh = string.Empty;
            if (Nam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            var query = @"INSERT INTO dbo.CUSTOMER
        ( IDCard ,
          IDCustomerType ,
          Name ,
          DateOfBirth ,
          Address ,
          PhoneNumber ,
          Sex ,
          Nationality
        )
VALUES  ( @cmnd , -- IDCard - nvarchar(100)
          1 , -- IDCustomerType - int
          @tenKhachHang , -- Name - nvarchar(100)
          @ngaySinh , -- DateOfBirth - date
          @diaChi , -- Address - nvarchar(200)
          0384863509 , -- PhoneNumber - int
          @gioiTinh , -- Sex - nvarchar(100)
          @quocTinh  -- Nationality - nvarchar(100)
        )";
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@cmnd", cmnd);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@tenKhachHang", hoTen);
                    cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@quocTinh", quocTich);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Thành Công");
                    showdata();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int maKhachHang = Int32.Parse(makhachhang.Text);
            var query = @"DELETE FROM dbo.CUSTOMER
WHERE ID = @id";
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query , connection);
                    cmd.Parameters.AddWithValue("@id", maKhachHang);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Thành Công");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
