using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComponentFactory.Krypton.Toolkit;
namespace Tez_v1
{
    class Command
    {
        SqlConnection sqlConnection;
        string sqlconnect = "Data Source=OKAN\\SQLEXPRESS;Initial Catalog=ERP_STOK_MODULU;Integrated Security=True";
        SqlDataReader sqlDataReader;
        SqlCommand cmd;

        public void openConnection()
        {
            sqlConnection = new SqlConnection(sqlconnect);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            sqlConnection = new SqlConnection(sqlconnect);
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public void DataReader(string s)
        {
            cmd = new SqlCommand(s, sqlConnection);

            sqlDataReader = cmd.ExecuteReader();

        }
        public KryptonComboBox comboFill(KryptonComboBox comboBox, string sorgu)
        {
            openConnection();
            comboBox.Items.Clear();
            DataReader(sorgu);
            comboBox.Items.Add("Seçiniz");

            while (sqlDataReader.Read())
            {
                comboBox.Items.Add(sqlDataReader[0].ToString());
            }
            sqlDataReader.Close();
            closeConnection();
            comboBox.SelectedIndex = 0;
            return comboBox;
        }

    }
}
