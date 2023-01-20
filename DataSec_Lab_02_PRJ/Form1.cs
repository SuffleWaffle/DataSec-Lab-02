using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSec_Lab_02_PRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pEncodeTB.Text = "0x";
            keyEncodeTB.Text = "0x";
            cDecodeTB.Text = "0x";
            keyDecodeTB.Text = "0x";
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int pInt = Convert.ToInt32(pEncodeTB.Text, 16);
                int keyInt = Convert.ToInt32(keyEncodeTB.Text, 16);
                int cInt = pInt ^ keyInt;
                cEncodeTB.Text = "0x" + Convert.ToString(cInt, 16).ToUpper();
                p2Lb.Text = "P 2 - " + Convert.ToString(pInt, 2);
                p10Lb.Text = "P 10 - " + Convert.ToString(pInt, 10);
                p16Lb.Text = "P 16 - " + Convert.ToString(pInt, 16).ToUpper();
                c2Lb.Text = "C 2 - " + Convert.ToString(cInt, 2);
                c10Lb.Text = "C 10 - " + Convert.ToString(cInt, 10);
                c16Lb.Text = "C 16 - " + Convert.ToString(cInt, 16).ToUpper();
                key2Lb.Text = "Key 2 - " + Convert.ToString(keyInt, 2);
                key10Lb.Text = "Key 10 - " + Convert.ToString(keyInt, 10);
                key16Lb.Text = "Key 16 - " + Convert.ToString(keyInt, 16).ToUpper();
            }
            catch (OverflowException)
            {
                MessageBox.Show("One of the values is too big!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong HEX value format!");
            }
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int cInt = Convert.ToInt32(cDecodeTB.Text, 16);
                int keyInt = Convert.ToInt32(keyDecodeTB.Text, 16);
                int pInt = cInt ^ keyInt;
                pDecodeTB.Text = "0x" + Convert.ToString(pInt, 16).ToUpper();
                p2Lb.Text = "P 2 - " + Convert.ToString(pInt, 2);
                p10Lb.Text = "P 10 - " + Convert.ToString(pInt, 10);
                p16Lb.Text = "P 16 - " + Convert.ToString(pInt, 16).ToUpper();
                c2Lb.Text = "C 2 - " + Convert.ToString(cInt, 2);
                c10Lb.Text = "C 10 - " + Convert.ToString(cInt, 10);
                c16Lb.Text = "C 16 - " + Convert.ToString(cInt, 16).ToUpper();
                key2Lb.Text = "Key 2 - " + Convert.ToString(keyInt, 2);
                key10Lb.Text = "Key 10 - " + Convert.ToString(keyInt, 10);
                key16Lb.Text = "Key 16 - " + Convert.ToString(keyInt, 16).ToUpper();
            }
            catch (OverflowException)
            {
                MessageBox.Show("One of the values is too big!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong HEX value format!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pEncodeTB.Text = "0x";
            keyEncodeTB.Text = "0x";
            cEncodeTB.Text = "";
            pDecodeTB.Text = "";
            keyDecodeTB.Text = "0x";
            cDecodeTB.Text = "0x";
            p2Lb.Text = "P 2 -";
            p10Lb.Text = "P 10 -";
            p16Lb.Text = "P 16 -";
            key2Lb.Text = "Key 2 -";
            key10Lb.Text = "Key 10 -";
            key16Lb.Text = "Key 16 -";
            c2Lb.Text = "C 2 -";
            c10Lb.Text = "C 10 -";
            c16Lb.Text = "C 16 -";
        }

        private void pEncodeTB_TextChanged(object sender, EventArgs e)
        {
            if (pEncodeTB.Text.Length < 2) { pEncodeTB.Text = "0x"; pEncodeTB.SelectionStart = 2; }
        }

        private void keyEncodeTB_TextChanged(object sender, EventArgs e)
        {
            if (keyEncodeTB.Text.Length < 2) { keyEncodeTB.Text = "0x"; keyEncodeTB.SelectionStart = 2; }
        }

        private void cDecodeTB_TextChanged(object sender, EventArgs e)
        {
            if (cDecodeTB.Text.Length < 2) { cDecodeTB.Text = "0x"; cDecodeTB.SelectionStart = 2; }
        }

        private void keyDecodeTB_TextChanged(object sender, EventArgs e)
        {
            if (keyDecodeTB.Text.Length < 2) { keyDecodeTB.Text = "0x"; keyDecodeTB.SelectionStart = 2; }
        }
    }
}
