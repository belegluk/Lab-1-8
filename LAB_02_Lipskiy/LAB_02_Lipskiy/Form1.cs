using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02_Olshewski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_key.Text = "";
            textBox_C.Text = "";
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            P2.Text = Convert.ToString(intP, 2).PadLeft(8, '0');
            P10.Text = Convert.ToString(intP, 10);
            P16.Text = Convert.ToString(intP, 16);

            string strKey = textBox_key.Text;
            int intKey = Convert.ToInt32(strKey, 16);
            key2.Text = Convert.ToString(intKey, 2);
            key10.Text = Convert.ToString(intKey, 10);
            key16.Text = Convert.ToString(intKey, 16);

            int intC = intP ^ intKey;
            C2.Text = Convert.ToString(intC, 2);
            C10.Text = Convert.ToString(intC, 10);
            C16.Text = Convert.ToString(intC, 16);
            textBox_C.Text = C16.Text;

            textBox_P_dec.Text = textBox_C.Text;
            textBox_key_dec.Text = textBox_key.Text;
            textBox_C_dec.Text = Convert.ToString(intC ^ intKey, 16);
        }
    }
}
