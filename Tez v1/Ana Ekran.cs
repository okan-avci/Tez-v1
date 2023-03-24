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
    public partial class Ana_Ekran : KryptonForm
    {
        
        public Ana_Ekran()
        {
            InitializeComponent();
        }

        private void Ana_Ekran_Load(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            stok.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Depo depo = new Depo();
            depo.Show();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Show();

        }
    }
}
