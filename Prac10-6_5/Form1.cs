using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac10_6_5
{
    public partial class Form1 : Form
    {

        protected const int xNum = 5;
        protected const int yNum = 4;
        protected bool[,] abChecked = new bool[yNum, xNum];
        protected int cxBlock, cyBlock;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OnResize(EventArgs.Empty);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            cxBlock = ClientSize.Width / xNum;
            cyBlock = ClientSize.Height / yNum;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X / cxBlock;
            int y = e.Y / cyBlock;

            if(x < xNum && y < yNum)
            {

                abChecked[y, x] ^= true;
                Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
                    

            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);
            for(int y=0;y<yNum;y++)
            for(int x = 0; x < xNum; x++)
                {

                    g.DrawRectangle(pen, x * cxBlock, y * cyBlock, cxBlock, cyBlock);
                    
                    if (abChecked[y, x])
                    {

                        g.DrawArc(pen, x * cxBlock, y * cyBlock, cxBlock, cyBlock, 0, 360);

                    }

                }

        }

     
    }
}
