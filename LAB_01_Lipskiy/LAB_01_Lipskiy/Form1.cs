using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_01_Olshewski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "NumbDigger" && textBox_pass.Text == "milkies")
            {
                label3.BackColor = Color.Wheat;
                label4.BackColor = Color.Wheat;
                MessageBox.Show("Hello");
            }
            else
            {
                if (textBox_login.Text == "NumbDigger")
                {
                    label3.BackColor = Color.Green;
                    label4.BackColor = Color.Red;
                }
                if(textBox_pass.Text == "milkies")
                {
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Green;
                }
                if (!(textBox_login.Text == "NumbDigger") && !(textBox_pass.Text == "milkies"))
                {
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Red;
                }                
                MessageBox.Show("Error! Fart Smella!");
            }
        }
    }
}
