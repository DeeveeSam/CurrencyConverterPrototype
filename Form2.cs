using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_Converter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxCurrency.Text =  "";
            txtBoxValue.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtBoxValue.Text);
            string currency = txtBoxCurrency.Text;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=currency";

            string query = "INSERT INTO currency_value VALUES('" + value + "', '" + currency + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Entry Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
