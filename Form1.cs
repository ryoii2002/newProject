using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int a = 0;
        static int b = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Text = a.ToString();
        }


        //계산버튼
        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case "+":
                    textBox4.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text)).ToString();
                    break;
                case "-":
                    textBox4.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox3.Text)).ToString();
                    break;
                case "*":
                    textBox4.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text)).ToString();
                    break;
                case "/":
                    textBox4.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox3.Text)).ToString();
                    break;
            }

        }

        // 나누기버튼
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "/";
            a = 1;
            textBox5.Text = a.ToString();
        }


        // + 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "+";
            a = 1;
            textBox5.Text = a.ToString();
        }

        // - 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-";
            a = 1;
            textBox5.Text = a.ToString();
        }

        // * 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "*";
            a = 1;
            textBox5.Text = a.ToString();
        }

        // 7번 버튼 메소드
        private void button10_Click(object sender, EventArgs e)
        {
            if(a == 0)
            {
                textBox1.Text += "7"; 
            }
            else
            {
                textBox3.Text += "7"; 
            }

        }

        //8
        private void button11_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox3.Text += "8";
            }
        }

        //9
        private void button12_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox3.Text += "9";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox3.Text += "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox3.Text += "5";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox3.Text += "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox3.Text += "1";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox3.Text += "2";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox3.Text += "3";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox3.Text += "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
