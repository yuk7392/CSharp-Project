using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac9_6_1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (count == 4)
               count = 0;

            if (count == 0)
            MessageBox.Show("MessageBoxButtons","Title Bar",MessageBoxButtons.OKCancel);
            if (count == 1)
                MessageBox.Show("MessageBoxButtons", "Title Bar", MessageBoxButtons.AbortRetryIgnore);
            if (count == 2)
                MessageBox.Show("MessageBoxButtons", "Title Bar", MessageBoxButtons.RetryCancel);
            if (count == 3)
                MessageBox.Show("MessageBoxButtons", "Title Bar", MessageBoxButtons.YesNoCancel);
            count++;

        }
    }
}
