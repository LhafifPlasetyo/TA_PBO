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
    public partial class FormCustomerManager : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public FormCustomerManager()
        {
            InitializeComponent();
        }

        void ClearText()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        void TampilkanBarang()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from account_table", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "account_table");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "account_table";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());

            }
            finally
            {
                conn.Close();
            }
        }

        private void FormCustomerManager_Load(object sender, EventArgs e)
        {
            TampilkanBarang();
            ClearText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" )
            {
                MessageBox.Show(" Invalid data details");
            }
            else
            {
                SqlConnection conn = Konn.GetConn(); 
                try
                {
                    cmd = new SqlCommand ("insert into account_table values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil");
                    TampilkanBarang();
                    ClearText();
     
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["USERNAME"].Value.ToString();
                textBox2.Text = row.Cells["PASSWORD"].Value.ToString();
                textBox3.Text = row.Cells["BarangPinjaman"].Value.ToString();
                textBox4.Text = row.Cells["StatusPeminjaman"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show(" Invalid data details");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update account_table Set PASSWORD='" + textBox2.Text + "',BarangPinjaman='" + textBox3.Text + "',StatusPeminjaman='" + textBox4.Text + "'where USERNAME='" + textBox4.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update Data Berhasil");
                    TampilkanBarang();
                    ClearText();

                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void btn_Hapus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            {
                cmd = new SqlCommand("Delete account_table where"
            }
               
        }
    }
}
