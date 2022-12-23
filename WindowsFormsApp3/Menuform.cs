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
        float tagihan;
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
                cmd = new SqlCommand("insert into Catalogue_Table values ('FIFA 23')", conn);
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                conn.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
                cmd = new SqlCommand("insert into Catalogue_Table values ('WWE 2K22')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into Catalogue_Table values ('Naruto Ultimate Ninja Storm 4')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into Catalogue_Table values ('eFootbal2022')", conn);
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("insert into Catalogue_Table values ('GTA V')", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            finally
            {
                view_list();
                conn.Close();
            }
        }

        void view_list()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from Catalogue_Table", conn);
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
    }
}
