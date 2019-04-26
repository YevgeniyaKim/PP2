using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox
{
    public partial class Form1 : Form
    {
        bool pressed = false;

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 8;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                textBox1.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Microsoft Sans Serif", (float)numericUpDown1.Value);
        }
    }
}
