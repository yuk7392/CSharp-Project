﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac9_6_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = false;
            fontDialog1.ShowColor = false;

            if (firstCheck.Checked)
                fontDialog1.ShowApply = true;
            if (secondCheck.Checked)
            fontDialog1.ShowColor = true;
                 
                fontDialog1.ShowDialog();
        }
    }
}
