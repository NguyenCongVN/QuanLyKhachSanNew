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
using QuanLyKhackSan.DataAcess;

namespace QuanLyKhachSan.GUI
{
    public partial class frmBookRoom : Form
    {
        public int MaLoaiPhongChon { get; set; }
        public frmBookRoom()
        {
            InitializeComponent();
            MaLoaiPhongChon = -1;
            InitDataGrid();
            gunaTextBox6.Text = SelectNextGenBookRoomId().ToString();
            gunaDateTimePicker1.Value = DateTime.Now;
            gunaDateTimePicker2.Value = DateTime.Now;
        }

        public void InitDataGrid()
        {
            var query = @"SELECT [ID] as 'Mã Loại Phòng'
      ,[Name] as 'Loại Phòng'
      ,[Price] as 'Giá'
      ,[LimitPerson] as 'Giới Hạn Người'
  FROM [HotelManagement].[dbo].[ROOMTYPE]";
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                DataTable table = new DataTable();
                connection.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connection);
                apter.Fill(table);
                connection.Close();
                showDataRoom.DataSource = table;
            }
        }

        public int SelectNextGenBookRoomId()
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                connection.Open();
                var query = "SELECT IDENT_CURRENT('dbo.BOOKROOM')";
                SqlCommand cmd = new SqlCommand(query, connection);
                return Int32.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                MaLoaiPhongChon = Int32.Parse(showDataRoom.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Đã Chọn Phòng Mã " + MaLoaiPhongChon);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Phòng không hợp lệ");
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkInRoom_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string hoTen = gunaTextBox1.Text;
            string cmnd = gunaTextBox2.Text;
            string diaChi = gunaTextBox3.Text;
            string quocTich = gunaTextBox4.Text;
            DateTime ngaySinh;
            try
            {
                ngaySinh = DateTime.Parse(gunaTextBox5.Text);
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
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MaLoaiPhongChon == -1)
            {
                MessageBox.Show("Chưa chọn loại phòng");
            }
            var query = @"DECLARE @customerId AS INT
            SELECT @customerId = ID
            FROM dbo.CUSTOMER WHERE
                IDCard = @idCard

            INSERT dbo.BOOKROOM
            (IDCustomer,
                IDRoomType,
                DateBookRoom,
                DateCheckIn,
                DateCheckOut
            )
            VALUES(@customerId, --IDCustomer - int
               @idRoomType , --IDRoomType - int
            GETDATE(), --DateBookRoom - smalldatetime
            @dateCheckIn, --DateCheckIn - date
            @dateCheckOut-- DateCheckOut - date
                )";
            string cmnd = gunaTextBox2.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idCard", cmnd);
                    cmd.Parameters.AddWithValue("@idRoomType", MaLoaiPhongChon);
                    cmd.Parameters.AddWithValue("@dateCheckIn", gunaDateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@dateCheckOut", gunaDateTimePicker2.Value);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Thành Công");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
