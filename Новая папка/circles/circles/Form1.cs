using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circles
{
    public partial class Form1 : Form
    {
        Rectangle rectangle = new Rectangle(10, 10, 30, 30);
        Random random;
        Graphics graphics;
        SolidBrush brush = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
            random = new Random(DateTime.Now.Millisecond);
            graphics = pictureBox1.CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangle.X = random.Next(0, pictureBox1.Width);
            rectangle.Y = random.Next(0, pictureBox1.Height);

            brush.Color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            graphics.FillEllipse(brush, rectangle);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }
    }
}
