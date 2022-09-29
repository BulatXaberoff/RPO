using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб2
{
    public partial class Form1 : Form
    {
        float deposit, profit;
        float[] rate = new float[] { 0.01f, 0.02f, 0.05f, 0.07f };
        public Form1()
        {
            
            int mounth;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            deposit =float.Parse(textBox1.Text);
            if (deposit<0)
            {
                MessageBox.Show("Ошибка");
            }
            int choice=-1;
            foreach (var item in Controls.OfType<RadioButton>())
                if (item.Checked)
                    choice = item.TabIndex;
            switch (choice)
            {
                case 0:
                    profit = rate[0] * deposit * 1 * 30 / 365;
                    break;
                case 1:
                    profit = rate[1] * deposit * 3 * 30 / 365;
                    break;
                case 2:
                    profit = rate[2] * deposit * 6 * 30 / 365;
                    break;
                case 3:
                    profit = rate[3] * deposit * 12 * 30 / 365;
                    break;
                default:
                    break;
            }
            profit = (float)Math.Round(profit, 2);
            label2.Text += $"Ваша процентная ставка {rate[choice]}% \nв месяц составит по вкладу {profit} рублей";

        }
    }
}
