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
        public static int them = 0;
        public static int sua =0;
        public static int xoa = 0;
        public frmManagerialCustomer()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            showdata();
            string query = "SELECT * FROM dbo.CUSTOMERTYPE";
            type_khach.DataSource = getData(query).Tables[0];
            type_khach.DisplayMember = getData(query).Tables[0].Columns[1].ToString();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void showdata()
        {
            string query = "   SELECT IDCard AS 'Số CMND', dbo.CUSTOMER.Name AS 'Họ tên',DateOfBirth AS 'Ngày sinh',Sex AS 'Giới tính', Address AS 'Địa chỉ',Nationality AS' Quốc tịch', dbo.CUSTOMERTYPE.Name AS 'Loại khách' FROM dbo.CUSTOMER JOIN dbo.CUSTOMERTYPE ON CUSTOMERTYPE.ID = CUSTOMER.IDCustomerType";
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
        public static DataSet getData(string query)
        {
            DataTable temp = new DataTable();
            ConnectionString cnn = new ConnectionString();
            string con = cnn.getConnectionString(frmLogin.checkConnectionString);
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(temp);
                connection.Close();

            }

            DataSet khachhang = new DataSet();
            khachhang.Tables.Add(temp);
            return khachhang;

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
            string query = "SELECT CUSTOMER.ID, CUSTOMER.Name,IDCard,DateOfBirth,Address,PhoneNumber,Sex,Nationality,CUSTOMERTYPE.Name AS Nametype FROM dbo.CUSTOMER JOIN dbo.CUSTOMERTYPE ON CUSTOMERTYPE.ID = CUSTOMER.IDCustomerType WHERE IDCard='" + maCart + "'";
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
            string gioitinh = data.Rows[0]["Sex"].ToString().TrimEnd();
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
            type_khach.Text= data.Rows[0]["Nametype"].ToString();
            string temp = data.Rows[0]["DateOfBirth"].ToString();
            int n2 = temp.IndexOf(" ");
            string temp1 = temp.Substring(0,n2);
            ngaysinh_kh.Value= DateTime.ParseExact(temp1, "M/d/yyyy", CultureInfo.InvariantCulture);
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
           /* makhachhang.Text = "";
            Name.Text = "";
            Sdt.Text = "";
            diachi.Text = "";
            CMND.Text = "";
            quoctich.Text = "";*/
            them = 1;
            sua = 0;
            xoa = 0;

            int check=insert();
            if(check==1)
            {
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("thêm thất bại");
            }
        }
        public int insert()
        {
            
            string name = Name.Text;
            string sdt = Sdt.Text;
            string Diachi = diachi.Text;
            string cmnd = CMND.Text;
            string Quoctich = quoctich.Text;
            DateTime date = ngaysinh_kh.Value;
            string gioitinh;
            if (Nam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            int type=1;
            string valueCol = type_khach.GetItemText(this.type_khach.SelectedItem).Trim();
            string query1 = "SELECT * FROM dbo.CUSTOMERTYPE where Name=N'" + valueCol + "'";
            string temp=getData(query1).Tables[0].Rows[0][0].ToString().Trim();
            type = Int32.Parse(temp);
            string query = " INSERT dbo.CUSTOMER( IDCard ,IDCustomerType ,Name ,DateOfBirth ,Address ,PhoneNumber ,Sex ,Nationality) VALUES  ( @idcart , @type , @name , @ngaysinh , @diachi ,  @sdt , @gioitinh , @quoctich)";
            ConnectionString cnn = new ConnectionString();
            string con = cnn.getConnectionString(frmLogin.checkConnectionString);
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    // insert value of Song in database
                    cmd.Parameters.Add("@idcart", SqlDbType.NVarChar).Value = cmnd;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = date.ToShortDateString().ToString();
                    cmd.Parameters.Add("@sdt", SqlDbType.Int).Value = sdt;
                    cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = Diachi;
                    cmd.Parameters.Add("@quoctich", SqlDbType.NVarChar).Value = Quoctich;

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                return 0;
            }
        }
    }
}
