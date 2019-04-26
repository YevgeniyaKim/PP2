using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool isOperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isOperation)
            {
                textBox1.Clear();
            }
            isOperation = false;
            Button button = (Button)sender;
            //if(button.Text == ".")
            //{
            //    if (!textBox1.Text.Contains("."))
            //    {
            //        textBox1.Text = textBox1.Text + button.Text;
            //    }
            //}
            //else
            textBox1.Text = textBox1.Text + button.Text;
            //textBox1.Text += ".";

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                equal_button.PerformClick();
                operation = button.Text;
                current_operation.Text = result + " " + operation;
                isOperation = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(textBox1.Text);
                current_operation.Text = result + " " + operation;
                isOperation = true;
            }
        }

        private void ce_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox1.Text);
            current_operation.Text = "";
        }

        private void pow_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double x;
                x = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(x);
            }
        }

        private void sqrt_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            }
        }

        private void arrow_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
