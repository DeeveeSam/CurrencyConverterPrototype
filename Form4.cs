using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Converter
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string password = txtBoxPassword.Text;
            if(password == "Dee_Admin")
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }
    }
}
