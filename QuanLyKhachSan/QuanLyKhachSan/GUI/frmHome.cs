using Guna.UI.WinForms;
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
    public partial class frmHome : Form
    {
        int WIDTH_MENU_MAX = 182;
        int WIDTH_MENU_MIN = 50;
        public frmHome()
        {
            InitializeComponent();
            tc_Menu_second.SizeMode = TabSizeMode.Fixed;
            tc_Menu_second.Appearance = TabAppearance.FlatButtons;
            tc_Menu_second.ItemSize = new Size(0, 1);
            tc_Content_Seclect.SizeMode = TabSizeMode.Fixed;
            tc_Content_Seclect.Appearance = TabAppearance.FlatButtons;
            tc_Content_Seclect.ItemSize = new Size(0, 1);
            tc_MainMenu.SizeMode = TabSizeMode.Fixed;
            tc_MainMenu.Appearance = TabAppearance.FlatButtons;
            tc_MainMenu.ItemSize = new Size(0, 1);
            this.hideMenu();
            tc_Menu_second.SelectedTab = noneContent;
            tc_Content_Seclect.SelectedTab = tabNoneContent;
            if(frmLogin.checkLogin == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
                this.Close();
            }
        }
        private void initData(string query, GunaDataGridView showData)
        {
            DataSet data = new DataSet();
            ConnectionString b = new ConnectionString();
            string con = b.getConnectionString(frmLogin.checkConnectionString);
            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, con);
                apter.Fill(data);
                connect.Close();
            }
            showData.DataSource = data.Tables[0];
        }
        private void showMenu()
        {
            pn_Menu_Parent.Width = WIDTH_MENU_MAX;
            btn_bill.Text = "Thanh Toán";
            btn_customer.Text = "Khách hàng";
            btn_emp.Text = "Nhân viên";
            btn_Syn.Text = "Trang chủ";
            btn_service.Text = "Dịch vụ";

        }
        private void hideMenu()
        {
            pn_Menu_Parent.Width = WIDTH_MENU_MIN;

            btn_bill.Text = "";
            btn_customer.Text = "";
            btn_emp.Text = "";
            btn_Syn.Text = "";
            btn_service.Text = "";

        }
        private void btn_Syn_Click(object sender, EventArgs e)
        {
            tc_Menu_second.SelectedTab = tab1;
            tc_Content_Seclect.SelectedTab = tabHome;
            string query = "SELECT ROOM.Name as [Tên Phòng] , dbo.ROOMTYPE.Name as [Loại Phòng], dbo.ROOMTYPE.Price as [Giá] , dbo.ROOMTYPE.LimitPerson as [Tối đa], dbo.STATUSROOM.Name as [Tình trạng] FROM dbo.ROOM , dbo.ROOMTYPE , dbo.STATUSROOM WHERE IDRoomType = ROOMTYPE.ID AND IDStatusRoom = STATUSROOM.ID";
            initData(query, showDataRoom);
        }


        private void btn_Bill_Click(object sender, EventArgs e)
        {
            tc_Menu_second.SelectedTab = tab3;
            tc_Content_Seclect.SelectedTab = tabBill;
        }

        private void btn_Sevice_Click(object sender, EventArgs e)
        {
            tc_Menu_second.SelectedTab = tab4;
            tc_Content_Seclect.SelectedTab = tabSevice;
            gunaDataGridView1.Columns.Clear();
            ConnectionString cnn = new ConnectionString();
            string con = cnn.getConnectionString(0);
            DataSet data = new DataSet();

            using (SqlConnection connect = new SqlConnection(con))
            {
                string query = " exec USP_LoadFullService";
                connect.Open();
                SqlDataAdapter apter = new SqlDataAdapter(query, connect);
                apter.Fill(data);
                connect.Close();
            }
            gunaDataGridView1.DataSource = data.Tables[0];
        }

        private void btn_Empoyment_Click(object sender, EventArgs e)
        {
            tc_Menu_second.SelectedTab = tab5;
            tc_Content_Seclect.SelectedTab = tabEmp;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            tc_Menu_second.SelectedTab = tab6;
            tc_Content_Seclect.SelectedTab = tabCustomer;
            string query = "SELECT * FROM dbo.CUSTOMER ";
            initData(query, showDataCustomer);
        }

        private void btn_controlMenu_Click(object sender, EventArgs e)
        {
            if (pn_Menu_Parent.Width == WIDTH_MENU_MAX)
            {
                hideMenu();
            }
            else
            {
                showMenu();
            }
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            tc_Menu_second.SelectedTab = tab7;
            tc_Content_Seclect.SelectedTab = tabSetting;
        }

        private void btn_ManagerialCustomer_Click(object sender, EventArgs e)
        {
            frmManagerialCustomer fmc = new frmManagerialCustomer();
            fmc.Show();
        }

        private void btn_ManagerialEmp_Click(object sender, EventArgs e)
        {
            frmManagerialEmp fme = new frmManagerialEmp();
            fme.Show();
        }

        private void btn_ManagerialService_Click(object sender, EventArgs e)
        {
            frmManagerialService fms = new frmManagerialService();
            fms.Show();
        }

        private void btn_bookRoom_Click(object sender, EventArgs e)
        {
            frmBookRoom fbr = new frmBookRoom();
            fbr.Show();
        }

        private void btn_checkInRoom_Click(object sender, EventArgs e)
        {
            frmCheckInRoom fci = new frmCheckInRoom();
            fci.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            frmAccount fa = new frmAccount();
            fa.Show();
        }
    }
}
