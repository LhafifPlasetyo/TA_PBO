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

namespace WindowsFormsApp3
{
    public partial class FormAdmin : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi Konn = new Koneksi();


        public FormAdmin()
        {
            InitializeComponent();
        }


        private void RegisterAdmin_Click(object sender, EventArgs e)
        {

        }

        private void Label_UserName_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Password_Click(object sender, EventArgs e)
        {

        }

        private void TxtBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username, u_password;

            username = TxtBoxt_UserName.Text;
            u_password = TxtBox_Password.Text;


            SqlConnection conn = Konn.GetConn();
            conn.Open();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (TxtBoxt_UserName.Text.Trim() == "" ^ TxtBox_Password.Text.Trim() == "")
            {
                MessageBox.Show("Data tidak lengkap");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                conn.Open();
                try
                {
                    cmd = new SqlCommand("Insert into account_table values ('" + TxtBoxt_UserName.Text + "','" + TxtBox_Password.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Akun berhasil di register");
                    TxtBoxt_UserName.Clear();
                    TxtBox_Password.Clear();
                    TxtBoxt_UserName.Focus();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

    }
}
