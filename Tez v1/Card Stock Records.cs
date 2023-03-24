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
    public partial class Card_Stock_Records : KryptonForm
    {
        public Card_Stock_Records()
        {
            InitializeComponent();
        }

        private void Card_Stock_Records_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Stock_Database__Stock_Code_ stock_Database = new Stock_Database__Stock_Code_();
            stock_Database.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Warehouse_Database warehouse_Database = new Warehouse_Database();
            warehouse_Database.Show();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            Warehouse_Identification warehouse_Identification = new Warehouse_Identification();
            warehouse_Identification.Show();
        }
    }
}
