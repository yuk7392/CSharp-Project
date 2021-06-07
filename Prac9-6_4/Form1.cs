using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prac9_6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            String dir = openFileDialog1.FileName;

            try
            {
               
                using (StreamReader sr = new StreamReader(dir))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        textBox1.Text += line + "\r\n";
                    }
                }

                /*
                 ***fileStream을 이용한 방법*** 
                 
                using (FileStream fs = File.OpenRead(dir))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        textBox1.Text += temp.getString(b) +"\r\n";
                    }
                }
            }
                */

            }
            catch (Exception)
            {
                Console.WriteLine("읽기에 실패하였습니다.");
             
            }
        }



    }
    }

