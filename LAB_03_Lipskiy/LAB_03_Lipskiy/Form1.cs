using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03_Olshewski
{
    public partial class Form1 : Form
    {
        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        // Use any sort of encoding you like. 
        //var binaryString = ToBinary(ConvertToByteArray("Welcome, World!", Encoding.UTF32));
        public Form1()
        {
            InitializeComponent();
        }

        void myShowToolTip(TextBox tB, byte[] arr)
        {
            string hexValues = BitConverter.ToString(arr);
            toolTip_HEX.SetToolTip(tB, ToBinary(ConvertToByteArray(hexValues, Encoding.UTF32)));
        }

        byte[] myXOR(byte[] arr_text, byte[] arr_key)
        {
            int len_text = arr_text.Length;
            int len_key = arr_key.Length;
            byte[] arr_cipher = new byte[len_text];
            for (int i = 0; i < len_text; i++)
            {
                byte p = arr_text[i];
                byte k = arr_key[i % len_key]; // mod
                byte c = (byte)(p ^ k); // XOR

                arr_cipher[i] = c;
            }
            return arr_cipher;
        }

        string myCipher(TextBox tb_text, TextBox tb_Key, TextBox tb_cipher, string cipher = "")
        {
            string text = tb_text.Text;
            byte[] arr_text;
            if (cipher == "") arr_text = Encoding.UTF32.GetBytes(text);
            else arr_text = Encoding.UTF32.GetBytes(cipher);
            myShowToolTip(tb_text, arr_text); // Створити підказку

            string key = tb_Key.Text;
            byte[] arr_key = Encoding.UTF32.GetBytes(key);
            myShowToolTip(tb_Key, arr_key); // Створити підказку

            byte[] arr_cipher = myXOR(arr_text, arr_key);

            //string cipher = BitConverter.ToString(arr_cipher).Replace("-", "");
            cipher = Encoding.UTF32.GetString(arr_cipher);
            tb_cipher.Text = cipher;
            myShowToolTip(tb_cipher, arr_cipher); // Створити підказку

            return cipher;
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {                    
            if (string.IsNullOrEmpty(textBox_key_IN.Text))
            {
                textBox_C_IN.Text = textBox_P_IN.Text;
                //MessageBox.Show("Ви забули ввести ключ?");
                //textBox_key_IN.Focus();
            }
            else
            {
                string cipher = myCipher(textBox_P_IN, textBox_key_IN, textBox_C_IN); // зашифрування
                textBox_P_OUT.Text = textBox_C_IN.Text;
                textBox_key_OUT.Text = textBox_key_IN.Text;
                myCipher(textBox_P_OUT, textBox_key_OUT, textBox_C_OUT, cipher); // розшифрування
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P_IN.Text = "";
            textBox_key_IN.Text = "";
            textBox_C_IN.Text = "";

            textBox_P_OUT.Text = "";
            textBox_key_OUT.Text = "";
            textBox_C_OUT.Text = "";
        }
    }
}
