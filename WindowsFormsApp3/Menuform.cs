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
        float tagihan = 0 ;
        Koneksi Konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        public Menuform()
        {
            InitializeComponent();
        }

        private void Menuform_Load(object sender, EventArgs e)
        {
            view_list();
            
            
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

            if (checkBox1.CheckState==CheckState.Checked)
            {
                tagihan += 40000; 
            }

        }

        private void button7_Click(object sender, EventArgs e)
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
                tagihan = 0;
                conn.Close();
            }
        }
    }
}
