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
    public partial class Stock_General_Screen : KryptonForm
    {
        public Stock_General_Screen()
        {
            InitializeComponent();
        }

        private void Stock_General_Screen_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Card_Stock_Records card_Stock_Records = new Card_Stock_Records();
            card_Stock_Records.Show();
        }
    }
}
