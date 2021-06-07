using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac8_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                resultBox.Text = (int.Parse(firstBox.Text) / int.Parse(secondBox.Text)).ToString();

            } catch(ArithmeticException)
            {

                resultBox.Text = "0으로 나눌 수 없습니다.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            resultBox.Text = (int.Parse(firstBox.Text) + int.Parse(secondBox.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultBox.Text = (int.Parse(firstBox.Text) - int.Parse(secondBox.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultBox.Text = (int.Parse(firstBox.Text) * int.Parse(secondBox.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                resultBox.Text = (int.Parse(firstBox.Text) % int.Parse(secondBox.Text)).ToString();

            }
            catch (ArithmeticException)
            {
                resultBox.Text = "0으로 나눌 수 없습니다.";
            }
        }
    }
}
