using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhackSan.DataAcess
{
    class ConnectionString
    {
        public string getConnectionString(int value)
        {
            if (value == 0)
            {
                return @"Data Source=localhost;Initial Catalog=HotelManagement;Integrated Security=True";
            }
            else
            {
                return @"Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";
            }
        }
        public int checkCnn()
        {
            try
            {
                string temp = @"Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(temp))
                {

                    connect.Open();
                    connect.Close();
                }
                return 1;
            }
            catch
            {

                string temp = @"Data Source=localhost;Initial Catalog=HotelManagement;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(temp))
                {

                    connect.Open();
                    connect.Close();
                }
                return 0;
            }

        }
    }
}
