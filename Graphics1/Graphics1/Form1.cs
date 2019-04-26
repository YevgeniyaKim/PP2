using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 4);
            graphics.DrawEllipse(pen, 10, 15, 40, 40);
            graphics.DrawRectangle(pen, 60, 70, 20, 20);
            graphics.DrawLine(pen, 150, 40, 180, 80);

            Brush brush = new SolidBrush(Color.Black);
            graphics.FillEllipse(brush, 10, 15, 40, 40);


            Point[] a = { new Point(40, 180), new Point(10, 210), new Point(70, 210) };
            graphics.DrawPolygon(pen, a);
        }
    }
}
