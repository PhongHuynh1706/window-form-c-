using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2;
        string op;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!Total.Text.Contains("."))
            {
                Total.Text = Total.Text + ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = float.Parse(Total.Text);
            Total.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = float.Parse(Total.Text);
            Total.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = float.Parse(Total.Text);
            Total.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = float.Parse(Total.Text);
            Total.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Total.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(Total.Text.Length > 0)
            {
                Total.Text = Total.Text.Remove(Total.Text.Length - 1, 1);
            }
            if(Total.Text.Length == 0)
            {
                Total.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(Total.Text);
            if (op == "+")
                result = num1 + num2;
            if (op == "-")
                result = num1 - num2;
            if (op == "*")
                result = num1 * num2;
            if (op == "/")
                if(num2 == 0)
                {
                    Total.Text = "Error";
                    
                
                }
                else { result = num1 / num2; }
                
            if (op == "%")
                result = num1 % num2;
            Total.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            op = "%";
            num1 = float.Parse(Total.Text);
            Total.Clear();
        }
    }
}
