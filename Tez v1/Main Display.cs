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
    public partial class Main_Display : KryptonForm
    {
        public Main_Display()
        {
            InitializeComponent();
        }

        private void Main_Display_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.Show();
        }
    }
}
