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
    public partial class StokKayıtGenelEkranı : KryptonForm
    {
        public StokKayıtGenelEkranı()
        {
            InitializeComponent();
        }

        private void StokKayıtGenelEkranı_Load(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Stok_Kartı_Kayıtları stok_Kartı_Kayıtları = new Stok_Kartı_Kayıtları();
            stok_Kartı_Kayıtları.Show();
        }
    }
}