using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Цена: ";
            label3.Text = "Количество: ";
            label4.Text = "Сумма: ";
            try
            {
                //int cost = 0;
                //int amount = 0;
                //int sum = 0;
                int a = Convert.ToInt16(textBox1.Text);
                if (a<0)
                {
                    MessageBox.Show("Ошибка");
                    return;
                }
                int choice = -1;
                foreach (var item in Controls.OfType<RadioButton>())
                    if (item.Checked)
                        choice = item.TabIndex;
                switch (choice)
                {
                    case 0:
                        label2.Text += "3,00р";
                        label3.Text += Convert.ToString(a) + "шт";
                        label4.Text += Convert.ToString(a * 3)+",00р";
                        break;
                    case 1:
                        label2.Text += "5,00р";
                        label3.Text += Convert.ToString(a) + "шт";
                        label4.Text += Convert.ToString(a * 5) + ",00р";
                        break;
                    case 2:
                        label2.Text += "7,00р";
                        label3.Text += Convert.ToString(a) + "шт";
                        label4.Text += Convert.ToString(a * 7) + ",00р";
                        break;
                    default:
                        MessageBox.Show("Ошибка");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
