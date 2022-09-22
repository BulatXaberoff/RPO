using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Раб6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, string> values = new Dictionary<int, string>
        {
            [0] = "",
            [1] = "Один",
            [2] = "Два",
            [3] = "Три",
            [4] = "Четыре",
            [5] = "Пять",
            [6] = "Шесть",
            [7] = "Семь",
            [8] = "Восемь",
            [9] = "Девять",
            [10] = "Десять",
            [11] = "Одиннадцать",
            [12] = "Двенадцать",
            [13] = "Тринадцать",
            [14] = "Четырнадцать",
            [15] = "Пятнадцать",
            [16] = "Шестнадцать",
            [17] = "Семнадтцать",
            [18] = "Восемьнадцать",
            [19] = "Девятьнадцать",
        };

        Dictionary<int, string> tennery = new Dictionary<int, string>
        {
            [2] = "Двадцать",
            [3] = "Тридцать",
            [4] = "Сорок",
            [5] = "Пятьдесять",
            [6] = "Шестьдесять",
            [7] = "Семьдесять",
            [8] = "Восемдесять",
            [9] = "Девяносто",
            [10] = "Сто",
        };

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text.Length == 1)
            {
                label2.Text = values[n];
            }
            if (textBox1.Text.Length == 2)
            {
                var sc = textBox1.Text.ToArray();
                int n1 = Convert.ToInt32(sc[0].ToString());
                int n2 = Convert.ToInt32(sc[1].ToString());

                if (n1 == 1)
                {
                    label2.Text = values[n];
                }
                else
                {
                    label2.Text = tennery[n1] + " " + values[n2];
                }
            }
            if (textBox1.Text == "100")
            {
                label2.Text = "Сто";
            }
            if (textBox1.Text == "0")
            {
                label2.Text = "Ноль";
            }
        }

    }
}
