using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 1;
            for(int i=1; i<=int.Parse(textBox1.Text); i++)
            {
                n *= i;
            }
            textBox1.Text = n.ToString();
        }
    }
}
