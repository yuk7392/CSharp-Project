﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac7_6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // button1.Show();
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // button1.Hide();
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
