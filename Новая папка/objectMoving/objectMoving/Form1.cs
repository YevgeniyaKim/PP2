using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objectMoving
{
    public partial class Form1 : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        private int x;
        private int y;
        private Position objPos;

        public Form1()
        {
            InitializeComponent();

            x = 50;
            y = 50;
            objPos = Position.Down;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, x, y, 100, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objPos == Position.Right)
            {
                x += 10;
            }
            else if (objPos == Position.Left)
            {
                x -= 10;
            }
            else if (objPos == Position.Up)
            {
                y -= 10;
            }
            else if (objPos == Position.Down)
            {
                y += 10;
            }

            Refresh();
            //Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                objPos = Position.Left;
            }
            else if(e.KeyCode == Keys.Right)
            {
                objPos = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                objPos = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                objPos = Position.Down;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }
    }
}
