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
    public partial class Menuform : Form
    {
        float tagihan = 0;
        string list_game;
        Koneksi Konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public static Menuform instance;

        public Menuform()
        {
            InitializeComponent();
            clear_list();
            string list_game = "";


        }

        private void Menuform_Load(object sender, EventArgs e)
        {
            view_list();
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("DELETE FROM item_list ", conn);
            cmd.ExecuteNonQuery();
            tagihan = 0;
            textBox1.Text = tagihan.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into item_list values ('FIFA 23')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                list_game += "FIFA 23 , ";
                plus_tagihan();
                conn.Close();
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into item_list values ('WWE 2K22')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                list_game += "WWE 2K22 , ";
                plus_tagihan();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into item_list values ('Naruto Ultimate Ninja Storm 4')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                list_game += "Naruto Ultimate Ninja Storm 4 , ";
                plus_tagihan();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into item_list values ('eFootbal2022')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                list_game += "eFootbal2022 , ";
                plus_tagihan();
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into item_list values ('GTA V')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                list_game += "GTA V, ";
                plus_tagihan();
                conn.Close();
            }
        }

        void view_list()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from item_list", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Catalogue_Table");
                Data_Game.DataSource = ds;
                Data_Game.DataMember = "Catalogue_Table";
                Data_Game.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void plus_tagihan()
        {
            tagihan += 10000;
            textBox1.Text = tagihan.ToString();

        }

        void clear_list()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM item_list ", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                list_game = "";
                tagihan = 0;
                textBox1.Text = tagihan.ToString();
                conn.Close();
            }
        }

        

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Konn.GetConn();
                string username, password;
                username = Form1.instance.txt1.Text;
                password = Form1.instance.txt2.Text;
                conn.Open();
                cmd = new SqlCommand("Update account_table Set USERNAME = '" + username + "',PASSWORD ='" + password + "',ITEMLIST ='" + list_game + "' where USERNAME = '" + username + "'", conn);
                cmd.ExecuteNonQuery();
            }

            finally
            {
                MessageBox.Show("Transaksi Berhasil");
                Form1 form_back = new Form1();
                form_back.Show();
                this.Hide();


            }
        }
        //clear list
        private void button7_Click_1(object sender, EventArgs e)
        {
            clear_list();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into item_list values ('Sewa TV')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                list_game += "Sewa TV, ";
                tagihan += 30000;
                textBox1.Text = tagihan.ToString();
                conn.Close();
            }
        }
    }
}