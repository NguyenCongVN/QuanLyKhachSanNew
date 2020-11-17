using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhackSan.DataAcess;

namespace QuanLyKhachSan.GUI
{
    public partial class frmBookRoom : Form
    {
        ConnectionString cnn = new ConnectionString();
        SqlConnection conn;
        SqlDataAdapter adap;
        string query = "";

        public frmBookRoom()
        {
            InitializeComponent();
        }
        void load()
        {
            query = "USP_LoadEmptyRoom";
            using (conn = new SqlConnection(cnn.getConnectionString(1)))
            {
                DataTable data_emptyroom = new DataTable();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new SqlDataAdapter(cmd);
                adap.Fill(data_emptyroom);
                showDataRoom.DataSource = data_emptyroom;
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

        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
