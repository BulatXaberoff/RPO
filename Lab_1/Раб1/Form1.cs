using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Раб1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 250000;
            foreach (var item in Controls.OfType<CheckBox>())
            {
                if (item.Checked)
                {
                    if (item.TabIndex==6)
                    {
                        sum += 9000;
                    }
                    if (item.TabIndex==7)
                    {
                        sum += 7000;
                    }
                    if (item.TabIndex==8)
                    {
                        sum += 8000;
                    }
                }
            }
            label4.Text = sum.ToString();
        }
    }
}
