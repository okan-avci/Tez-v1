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
    public partial class FaturaKayıtGenelEkranı : KryptonForm
    {
        public FaturaKayıtGenelEkranı()
        {
            InitializeComponent();
        }

        private void FaturaKayıtGenelEkranı_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            AlışFaturası alışFaturası = new AlışFaturası();
            alışFaturası.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SatısFaturası satısFaturası = new SatısFaturası();
            satısFaturası.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            CariKartıKaydı cariKartıKaydı = new CariKartıKaydı();
            cariKartıKaydı.Show();
        }
    }
}
