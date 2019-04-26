using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smile
{
    public partial class Form1 : Form
    {
        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        Direction direction = Direction.Right;
        int x = 0;
        int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            timer1.Enabled = true;
            if(x==0 && y==0)
            {
                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
                pictureBox1.Refresh();
            }

            if(btn.Text=="up")
            {
                direction = Direction.Up;
            }
            else if (btn.Text == "down")
            {
                direction = Direction.Down;
            }
            else if (btn.Text == "left")
            {
                direction = Direction.Left;
            }
            else if (btn.Text == "right")
            {
                direction = Direction.Right;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Black), x, y, 30, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(direction == Direction.Right)
            {
                x += 5;
            }
            else if (direction == Direction.Left)
            {
                x -= 5;
            }
            if (direction == Direction.Up)
            {
                y -= 5;
            }
            if (direction == Direction.Down)
            {
                y += 5;
            }
            pictureBox1.Refresh();
        }
    }
}
