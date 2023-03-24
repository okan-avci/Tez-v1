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
    public partial class Warehouse_General_Screen : KryptonForm
    {
        public Warehouse_General_Screen()
        {
            InitializeComponent();
        }

        private void Warehouse_General_Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            Warehouse_Identification warehouse_Identification = new Warehouse_Identification();
            warehouse_Identification.Show();
        }
    }
}
