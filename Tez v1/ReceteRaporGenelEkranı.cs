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
    public partial class ReceteRaporGenelEkranı : KryptonForm
    {
        public ReceteRaporGenelEkranı()
        {
            InitializeComponent();
        }

        private void ReceteRaporGenelEkranı_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Reçete_İzleme reçete_İzleme = new Reçete_İzleme();
            reçete_İzleme.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Reçete_Listesi reçete_Listesi = new Reçete_Listesi();
            reçete_Listesi.Show();
        }
    }
}
