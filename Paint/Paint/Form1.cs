using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public enum Tools
    {
        pen,
        erase,
        line,
        rectangle,
        ellipse,
        fill
    }

    public partial class Paint : Form
    {
        Pen pen;
        Pen erase;
        Bitmap bitmap;
        Graphics graphics;
        Point firstP, secondP;
        Tools tools = Tools.pen;

        public Paint()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 4);
            erase = new Pen(Color.White, 20);
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void pen_button_Click(object sender, EventArgs e)
        {
            tools = Tools.pen;
        }

        private void erase_button_Click(object sender, EventArgs e)
        {
            tools = Tools.erase;
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void line_button_Click(object sender, EventArgs e)
        {
            tools = Tools.line;
        }

        private void rectangle_button_Click(object sender, EventArgs e)
        {
            tools = Tools.rectangle;
        }

        Rectangle rectangle(Point p1, Point p2)
        {
            Rectangle result = new Rectangle();
            result.X = Math.Min(p1.X, p2.X);
            result.Y = Math.Min(p1.Y, p2.Y);
            result.Width = Math.Abs(p1.X - p2.X);
            result.Height = Math.Abs(p1.Y - p2.Y);
            return result;
        }

        private void ellipse_button_Click(object sender, EventArgs e)
        {
            tools = Tools.ellipse;
        }

        private void fill_button_Click(object sender, EventArgs e)
        {
            tools = Tools.fill;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
            erase.Width = trackBar1.Value;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstP = e.Location;
            if (tools == Tools.fill)
            {
                DummyFill dummyFill = new DummyFill();
                dummyFill.Fill(bitmap, pen.Color, e.Location);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                secondP = e.Location;
                switch (tools)
                {
                    case Tools.pen:
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(pen, firstP, secondP);
                        firstP = secondP;
                        break;
                    case Tools.erase:
                        erase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        erase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(erase, firstP, secondP);
                        firstP = secondP;
                        break;
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (tools)
            {
                case Tools.line:
                    secondP = e.Location;
                    graphics.DrawLine(pen, firstP, secondP);
                    pictureBox1.Refresh();
                    break;
                case Tools.rectangle:
                    graphics.DrawRectangle(pen, rectangle(firstP, secondP));
                    break;
                case Tools.ellipse:
                    graphics.DrawEllipse(pen, rectangle(firstP, secondP));
                    break;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (tools)
            {
                case Tools.line:
                    e.Graphics.DrawLine(pen, firstP, secondP);
                    break;
                case Tools.rectangle:
                    e.Graphics.DrawRectangle(pen, rectangle(firstP, secondP));
                    break;
                case Tools.ellipse:
                    e.Graphics.DrawEllipse(pen, rectangle(firstP, secondP));
                    break;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            bitmap = new Bitmap(openFileDialog1.FileName);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void checkSmooth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSmooth.Checked)
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            else
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            }
        }
    }
}
