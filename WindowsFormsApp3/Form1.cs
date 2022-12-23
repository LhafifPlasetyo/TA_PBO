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
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        public static Form1 instance;
        public TextBox txt1, txt2;


        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
            instance = this;
            txt1 = txt_username;
            txt2 = txt_password;
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            String username, u_password;
            username = txt_username.Text;
            u_password = txt_password.Text;


            SqlConnection conn = Konn.GetConn();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from account_table where USERNAME = '" + txt_username.Text + "'and PASSWORD = '" + txt_password.Text + "'", conn);

            DataTable dTable = new DataTable();
            adapter.Fill(dTable);

            if (dTable.Rows.Count > 0)
            {
                username = txt_username.Text;
                u_password = txt_password.Text;
                //Masuk ke menu berikutnya
                Menuform form2 = new Menuform();
                form2.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();

            }

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == "" ^ txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Data tidak lengkap");

            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                conn.Open();
                try
                {
                    cmd = new SqlCommand("insert into account_table values ('" + txt_username.Text + "','" + txt_password.Text + "','NULL')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Akun berhasil di register");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin();
            form.Show();
            this.Hide();
        }
    }
}