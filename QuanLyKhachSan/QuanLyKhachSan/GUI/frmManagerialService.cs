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
    public partial class frmManagerialService : Form
    {
        public frmManagerialService()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void Exc(string query)
        {     
            ConnectionString b = new ConnectionString();
            string con = b.getConnectionString(frmLogin.checkConnectionString);
            using (SqlConnection connect = new SqlConnection(con))
            {

                connect.Open();
                SqlCommand cmd = new SqlCommand(query,connect);
                cmd.ExecuteScalar();
                
                connect.Close();
            }
        }
        private void LockControl()
        {
            thongtindichvu.Enabled = false;
        }

        private void UnlockControl()
        {
            thongtindichvu.Enabled = true;
        }
        private void ClearControl()
        {
            txttendichvu.Text = "";
            txtMaloaidichvu.Text = "";
            txtmadichvu.Text = "";
            txtloaidichvu.Text = "";
            txtgia.Text = "";
           
        }
        private void frmManagerialService_Load(object sender, EventArgs e)
        {
            string query = " exec USP_LoadFullService";
            initData(query, showDataService);
            LockControl();
        }

        private void showDataService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmadichvu.Text = showDataService.CurrentRow.Cells[0].Value.ToString();
            txttendichvu.Text = showDataService.CurrentRow.Cells[1].Value.ToString();
            txtgia.Text = showDataService.CurrentRow.Cells[2].Value.ToString();
            txtloaidichvu.Text = showDataService.CurrentRow.Cells[3].Value.ToString();
            txtMaloaidichvu.Text = showDataService.CurrentRow.Cells[4].Value.ToString();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearControl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "exec USP_UpdateService " + txtmadichvu.Text + ", N'" + txttendichvu.Text
                    + "' ," + txtMaloaidichvu.Text + " ," + txtgia.Text;
                Exc(query);
                frmManagerialService_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Không thể sửa");
            }
        }
    }
}
