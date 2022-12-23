using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Akun
    {

        public string UserName;
        public string Password;
        public float tagihan = 0;

        public void plus_tagihan()
        {
            tagihan += 10000;

        }
    }
}