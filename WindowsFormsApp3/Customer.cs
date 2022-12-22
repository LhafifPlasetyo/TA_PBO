using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp3
{
    internal class Customer : Akun
    {
        public int JumlahTagihan = 0;
        public List<string> BarangPinjaman = new List<string>();

        //Fungsi tambah barang ke dalam List 
        //jadi nanti fungsi ini tinggal dipanggil tiap mencet
        //button game di page pilih game
        public void addBarang()
        {
            //BarangPinjaman.Add( string[nama game])

            //JumlahTagihan += (hargaGame)

        }

        public Customer(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        
        
    }
}
