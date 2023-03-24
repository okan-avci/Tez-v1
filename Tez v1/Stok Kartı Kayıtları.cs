using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Tez_v1
{
    public partial class Stok_Kartı_Kayıtları : KryptonForm
    {
        public Stok_Kartı_Kayıtları()
        {
            InitializeComponent();
        }

        private void Stok_Kartı_Kayıtları_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            Depo_Tanımlama depo_Tanımlama = new Depo_Tanımlama();
            depo_Tanımlama.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Stok_Veritabanı__Stok_Kodu_ stok_Veritabanı = new Stok_Veritabanı__Stok_Kodu_();
            stok_Veritabanı.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Depo_Veritabanı depo_Veritabanı = new Depo_Veritabanı();
            depo_Veritabanı.Show();
        }
    }
}
