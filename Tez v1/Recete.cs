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
    public partial class Recete : KryptonForm
    {
        public Recete()
        {
            InitializeComponent();
        }

        private void Recete_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Recete_kayıt_genel_ekranı recete_Kayıt_Genel_Ekranı = new Recete_kayıt_genel_ekranı();
            recete_Kayıt_Genel_Ekranı.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ReceteRaporGenelEkranı receteRaporGenelEkranı = new ReceteRaporGenelEkranı();
            receteRaporGenelEkranı.Show();
        }
    }
}
