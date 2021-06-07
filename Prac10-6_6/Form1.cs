using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac10_6_6
{
    public partial class Form1 : Form
    {
        bool shift = false, alt = false, ctrl = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1 && (e.Shift)) MessageBox.Show(e.KeyCode.ToString()+"+Shift");
            if (e.KeyCode == Keys.F1 && (e.Alt)) MessageBox.Show(e.KeyCode.ToString() + "+Alt");
            if (e.KeyCode == Keys.F1 && (e.Control)) MessageBox.Show(e.KeyCode.ToString() + "+Control"); 

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Shift) shift = true;
            if (e.Control) ctrl = true;
            if (e.Alt) alt = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (shift)
                MessageBox.Show(e.KeyCode.ToString() + "+Shift");
            if (ctrl)
                MessageBox.Show(e.KeyCode.ToString() + "+Control");
            if (alt)
                MessageBox.Show(e.KeyCode.ToString() + "+Alt");

            if (!shift && !ctrl && !alt)
                MessageBox.Show(e.KeyCode.ToString());

            shift = false;
            ctrl = false;
            alt = false;

        }
    }
}
