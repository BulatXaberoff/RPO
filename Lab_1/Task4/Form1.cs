using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        double a, b;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text += 9;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;

        }

       
        private void equal_button_Click(object sender, EventArgs e)
        {
            clac();
            label1.Text = "";

        }

        private void clac()
        {
            switch (count)
            {
                case 1:
                    b = a + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a % Convert.ToDouble(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Sum_button_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
        }

        private void multi_button_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "*";
        }

        private void Remains_button_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = a.ToString() + "%";
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            int ind = textBox1.Text.Length - 1;
            textBox1.Text = textBox1.Text.Remove(ind);
        }

        private void All_Clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "/";
        }
    }
}
