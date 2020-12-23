using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frmCheckInRoom : Form
    {
        public frmCheckInRoom()
        {
            InitializeComponent();
            txt_user.Text = frmLogin.MaNhanVien;
            InitDataGrid();
        }

        public frmCheckInRoom(int maPhong)
        {
            InitializeComponent();
            btn_CheckIn.Enabled = false;
            bunifuFlatButton5.Enabled = false;

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                var query = @"SELECT dbo.BOOKROOM.ID
FROM dbo.ROOM
INNER JOIN dbo.RECEIVEROOM
ON RECEIVEROOM.IDRoom = ROOM.ID
INNER JOIN dbo.BOOKROOM
ON BOOKROOM.ID = RECEIVEROOM.IDBookRoom
WHERE dbo.ROOM.Name = @roomName
ORDER BY DATEDIFF(DAY, DateCheckIn , GETDATE()) DESC";
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@roomName", maPhong);
                    gunaTextBox1.Text = cmd.ExecuteScalar().ToString();
                    btn_confim_Click(null, null);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }


        public void InitDataGrid()
        {
            var query = @"SELECT ROOM.ID AS 'Mã Phòng' ,
       ROOM.Name AS 'Tên Phòng' ,
       ROOMTYPE.Name 'Loại Phòng' ,
       Price AS 'Giá' ,
       LimitPerson AS 'Số Người' ,
       STATUSROOM.Name AS 'Tình Trạng' FROM dbo.ROOM INNER JOIN dbo.ROOMTYPE
ON ROOMTYPE.ID = ROOM.IDRoomType
INNER JOIN dbo.STATUSROOM
ON STATUSROOM.ID = ROOM.IDStatusRoom
";
            using (var connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                var table = new DataTable();
                connection.Open();
                var apter = new SqlDataAdapter(query, connection);
                apter.Fill(table);
                connection.Close();
                showDataRoom.DataSource = table;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            int maPhong;
            try
            {
                maPhong = int.Parse(showDataRoom.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            gunaTextBox7.Text = maPhong.ToString();
        }

        private enum CheckInRoom
        {
            DateBookRoom,
            DateCheckIn,
            DateCheckOut,
            ID,
            IDCard,
            Name,
            DateOfBirth,
            Address,
            PhoneNumber,
            Sex,
            Nationality
        }

        #region Hand click button

        private void btn_confim_Click(object sender, EventArgs e)
        {

            var bookId = 0;
            try
            {
                bookId = int.Parse(gunaTextBox1.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hãy Nhập vào mã đặt phòng đúng");
                return;
            }


            var query1 = @"SELECT dbo.ROOM.ID
FROM dbo.RECEIVEROOM
INNER JOIN dbo.BOOKROOM
ON BOOKROOM.ID = RECEIVEROOM.IDBookRoom
INNER JOIN dbo.ROOM
ON ROOM.ID = RECEIVEROOM.IDRoom
WHERE BOOKROOM.ID = @bookRoomId";

            int roomIdDaDat = 0;

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query1, connection);
                    cmd.Parameters.AddWithValue("@bookRoomId", bookId);
                    object checkScalar = cmd.ExecuteScalar();
                    if (checkScalar != null)
                    {
                        roomIdDaDat = Int32.Parse(checkScalar.ToString());
                    }
                    gunaTextBox7.Text = roomIdDaDat.ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            

            var query = @"SELECT 
       DateBookRoom ,
       DateCheckIn ,
       DateCheckOut ,
       CUSTOMER.ID ,
       IDCard ,
       Name ,
       DateOfBirth ,
       Address ,
       PhoneNumber ,
       Sex ,
       Nationality FROM dbo.BOOKROOM
INNER JOIN dbo.CUSTOMER
ON CUSTOMER.ID = BOOKROOM.IDCustomer
WHERE BOOKROOM.ID = @bookId";

            using (var connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                try
                {
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    var adapter = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);


                    var hoTen = table.Rows[0].Field<string>((int)CheckInRoom.Name);
                    var cmnd = table.Rows[0].Field<string>((int)CheckInRoom.IDCard);
                    var diaChi = table.Rows[0].Field<string>((int)CheckInRoom.Address);
                    var quocTich = table.Rows[0].Field<string>((int)CheckInRoom.Nationality);
                    DateTime ngaySinh;
                    try
                    {
                        ngaySinh = table.Rows[0].Field<DateTime>((int)CheckInRoom.DateOfBirth);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Lỗi Xảy Ra");
                        return;
                    }

                    DateTime ngayCheckIn;
                    try
                    {
                        ngayCheckIn = table.Rows[0].Field<DateTime>((int)CheckInRoom.DateCheckIn);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Lỗi Xảy Ra");
                        return;
                    }


                    DateTime ngayCheckOut;
                    try
                    {
                        ngayCheckOut = table.Rows[0].Field<DateTime>((int)CheckInRoom.DateCheckOut);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Lỗi Xảy Ra");
                        return;
                    }


                    var gioiTinh = table.Rows[0].Field<string>((int)CheckInRoom.Sex);

                    gunaTextBox2.Text = cmnd;
                    gunaTextBox3.Text = diaChi;
                    gunaTextBox4.Text = quocTich;
                    gunaTextBox5.Text = ngaySinh.ToString("dd/MM/yyyy");

                    if (gioiTinh == "Nam")
                        Nam.Checked = true;
                    else
                        radioButton1.Checked = true;

                    gunaTextBox6.Text = hoTen;
                    gunaDateTimePicker1.Value = ngayCheckIn;
                    gunaDateTimePicker2.Value = ngayCheckOut;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
            }
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            var query = @"INSERT INTO dbo.RECEIVEROOM
        ( IDBookRoom, IDRoom )
VALUES  ( @bookId, -- IDBookRoom - int
          @roomId  -- IDRoom - int
          )

UPDATE dbo.ROOM
SET IDStatusRoom = 1
WHERE ID = @roomId
"
                ;
            var bookId = 0;
            try
            {
                bookId = int.Parse(gunaTextBox1.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hãy Nhập vào mã đặt phòng đúng");
                return;
            }

            var roomId = 0;
            try
            {
                roomId = int.Parse(gunaTextBox7.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hãy Nhập vào mã đặt phòng đúng");
                return;
            }

            using (var connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Thành Công");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btn_removeRoom_Click(object sender, EventArgs e)
        {
            var query = @"DECLARE @roomId AS INT

DECLARE @idReceiveRoom AS INT

SELECT @idReceiveRoom = RECEIVEROOM.ID , @roomId = dbo.ROOM.ID
FROM dbo.RECEIVEROOM
INNER JOIN dbo.BOOKROOM
ON BOOKROOM.ID = RECEIVEROOM.IDBookRoom
INNER JOIN dbo.ROOM
ON ROOM.ID = RECEIVEROOM.IDRoom
WHERE BOOKROOM.ID = @bookRoomId

UPDATE dbo.ROOM
SET IDStatusRoom = 4
WHERE ID = @roomId

DECLARE @price AS INT
SELECT @price = Price * (DATEDIFF( DAY,DateCheckIn, DateCheckOut))
FROM dbo.BOOKROOM
INNER JOIN dbo.ROOMTYPE
ON ROOMTYPE.ID = BOOKROOM.IDRoomType
WHERE dbo.BOOKROOM.ID = @bookRoomId



INSERT INTO dbo.BILL
        ( IDReceiveRoom ,
          StaffSetUp ,
          DateOfCreate ,
          RoomPrice ,
          ServicePrice ,
          Surcharge ,
          TotalPrice ,
          Discount ,
          IDStatusBill
        )
VALUES  ( @idReceiveRoom , -- IDReceiveRoom - int
          @staffId , -- StaffSetUp - nvarchar(100)
          GETDATE() , -- DateOfCreate - smalldatetime
          @price , -- RoomPrice - int
          0 , -- ServicePrice - int
          0 , -- Surcharge - int
          @price , -- TotalPrice - int
          0 , -- Discount - int
          1  -- IDStatusBill - int
        )";


            var bookId = 0;
            try
            {
                bookId = int.Parse(gunaTextBox1.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hãy Nhập vào mã đặt phòng đúng");
                return;
            }

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString.getConnectionString(1)))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@bookRoomId", bookId);
                    cmd.Parameters.AddWithValue("@staffId", frmLogin.MaNhanVien);
                    cmd.ExecuteScalar();
                    MessageBox.Show("Hủy Thành Công");
                    InitDataGrid();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}