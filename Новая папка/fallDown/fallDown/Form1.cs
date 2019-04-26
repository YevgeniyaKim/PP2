using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fallDown
{
    public partial class Form1 : Form
    {
        public Rectangle rectangle;
        public Random random = new Random(DateTime.Now.Millisecond);
        public Graphics graphics;
        public SolidBrush brush = new SolidBrush(Color.Black);
        public int x, y;

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            rectangle = new Rectangle(x, y, 50, 50);
            graphics.FillEllipse(brush, rectangle);

            y += 10;
        }
    }
}
