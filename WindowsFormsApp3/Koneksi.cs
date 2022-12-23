using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Ngodeeng\File C#\RentalPS TA PBO\WindowsFormsApp3\login_tabel.mdf;Integrated Security=True;Connect Timeout=30";
            return Conn;
        }
    }
}
