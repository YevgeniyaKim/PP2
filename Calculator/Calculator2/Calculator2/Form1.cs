using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        enum Operation
        {
            PLUS,
            MIN,
            MUL,
            DIV,
            NONE
        }
        string first = " ";
        string second = " ";
        Operation o = Operation.NONE;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = " ";
            o = Operation.PLUS;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = " ";
            o = Operation.MIN;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = " ";
            o = Operation.MUL;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = " ";
            o = Operation.DIV;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            second = textBox1.Text;
            double ans;
            if(o==Operation.MUL)
            {
                ans = double.Parse(first) * double.Parse(second);
                textBox1.Text = ans.ToString();
            }

            if (o == Operation.MIN)
            {
                ans = double.Parse(first) - double.Parse(second);
                textBox1.Text = ans.ToString();
            }

            if (o == Operation.DIV)
            {
                ans = double.Parse(first) / double.Parse(second);
                textBox1.Text = ans.ToString();
            }

            if (o == Operation.PLUS)
            {
                ans = double.Parse(first) + double.Parse(second);
                textBox1.Text = ans.ToString();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=" ")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                textBox1.Text += ",";
            }
        }
    }
}
