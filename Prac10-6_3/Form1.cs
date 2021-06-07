using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac10_6_3
{
    public partial class Form1 : Form
    {

        int firstX = 0;
        int firstY = 0;
        int lastX = 0;
        int lastY = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);

            g.DrawRectangle(pen, firstX, firstY, firstX > lastX ? firstX-lastX : lastX-firstX, firstY > lastY ? firstY-lastY : lastY - firstY);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            firstX = e.X;
            firstY = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;

            Invalidate();

        }
    }
}
