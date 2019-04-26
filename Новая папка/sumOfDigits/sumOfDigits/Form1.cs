using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumOfDigits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first = int.Parse(textBox1.Text);
            int sum = 0;
            while(first > 0)
            {
                sum += first % 10;
                first / 10;
            }
            textBox2.Text = sum.ToString();
        }
    }
}
