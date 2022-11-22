using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove((textBox1.Text.Length - 1), 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            char[] charArr = textBox1.Text.ToCharArray();
            int helper = charArr.Length;
            String a = "", b = "";
            char sign = ' ';

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '+' || charArr[i] == '-' || charArr[i] == '*' || charArr[i] == '/')
                {
                    helper = i + 1;
                    sign = charArr[i];
                }
                else
                {
                    if (i >= helper)
                    {
                        b += charArr[i];
                    }
                    else
                    {
                        a += charArr[i];
                    }
                }
            }

            double result = 0;

            switch (sign)
            {
                case '+':
                    result = Convert.ToDouble(a) + Convert.ToDouble(b);
                    textBox1.Text = Convert.ToString(result);
                    break;
                case '-':
                    result = Convert.ToDouble(a) - Convert.ToDouble(b);
                    textBox1.Text = Convert.ToString(result);
                    break;
                case '*':
                    result = Convert.ToDouble(a) * Convert.ToDouble(b);
                    textBox1.Text = Convert.ToString(result);
                    break;
                case '/':
                    if (Convert.ToDouble(b) == 0)
                    {
                        textBox1.Text = "You can`t divide by zero!!!";
                    }
                    else
                    {
                        result = Convert.ToDouble(a) / Convert.ToDouble(b);
                        textBox1.Text = Convert.ToString(result);
                    }
                    
                    break;
                default:
                    textBox1.Text = "ERROR!!!";
                    break;

            }
        }
    }
}
