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
    public partial class Recete_kayıt_genel_ekranı : KryptonForm
    {
        public Recete_kayıt_genel_ekranı()
        {
            InitializeComponent();
        }

        private void Recete_kayıt_genel_ekranı_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Recete_Kaydı recete_Kaydı = new Recete_Kaydı();
            recete_Kaydı.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
