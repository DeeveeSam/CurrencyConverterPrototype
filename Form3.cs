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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=currency";

            string query = "SELECT * from currency_value ";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                while(reader.Read())
                {
                    string currency = reader.GetString("Currency_Name");
                    comboFrom.Items.Add(currency);
                    comboTo.Items.Add(currency);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxAmount.Text = "";
            comboFrom.SelectedItem = null;
            comboTo.SelectedItem = null;
            txtBoxResult.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
           
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=currency";
            string newCurrency = comboTo.Text;

           

            string currencyvalue = "";
           

            double money = Convert.ToDouble(txtBoxAmount.Text);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * from currency_value WHERE Currency_Name=@cname", databaseConnection);
            commandDatabase.Parameters.AddWithValue("@cname", newCurrency);
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {

                currencyvalue = reader.GetValue(0).ToString();

            }
            databaseConnection.Close();

            



            double exchangRate = Convert.ToDouble(currencyvalue);


            double newmoney = (money * exchangRate);
            txtBoxResult.Text = newmoney.ToString();


        }
    }
}