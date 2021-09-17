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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(radbtnAdmin.Checked == true)
            {
                this.Hide();
                Form4 frm4 = new Form4();
                frm4.Show();
            }

            else if(radbtnUser.Checked == true)
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Show();
            }

            else
            {
                MessageBox.Show("Choose between Admin or User");
            }
        }
    }
}
