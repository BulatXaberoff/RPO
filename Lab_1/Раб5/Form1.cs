using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Раб5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                float dist = float.Parse(textBox1.Text);
                float cost = (float)(dist * 10*1.25);
                label1.Text=cost.ToString()+"р";
            }
            if (radioButton2.Checked)
            {
                float dist = float.Parse(textBox1.Text);
                float cost = (float)(dist * 10);
                label1.Text = cost.ToString()+"р";
            }
        }
    }
}
