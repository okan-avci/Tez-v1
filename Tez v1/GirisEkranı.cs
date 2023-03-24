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
using System.Data.SqlClient;

namespace Tez_v1
{
    public partial class GirisEkranı : KryptonForm
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void GirisEkranı_Load(object sender, EventArgs e)
        {
            Command command = new Command();
            command.comboFill(kryptonComboBox3, "select SirketAdı from SİRKET ");
            command.comboFill(kryptonComboBox1, "select DİL from DIL ");
            command.comboFill(kryptonComboBox2, "select Veritabani from VERITABANI ");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonComboBox1.Text == "English")
            {
                this.Hide();
                Main_Display main_Display = new Main_Display();
                main_Display.Show();
            }
            else if (kryptonComboBox1.Text == "Türkçe")
            {
                this.Hide();
                Ana_Ekran ana_Ekran = new Ana_Ekran();
                ana_Ekran.Show();
            }
            else { MessageBox.Show("Dili Seçiniz"); }
        }
    }
}
