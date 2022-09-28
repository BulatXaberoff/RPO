using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Раб3
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
            try
            {
                int model = comboBox1.SelectedIndex;
                float cost = float.Parse(textBox1.Text);
                float power = float.Parse(textBox2.Text);
                float age_skill = float.Parse(textBox3.Text);
                float age_exploitation = float.Parse(textBox4.Text);
                var res = 0.0;
                res = Kasko(model, cost, power, age_skill, age_exploitation, res);
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private double Kasko(int model, float cost, float power, float age_skill, float age_exploitation, double res)
        {
            if (age_exploitation>10 && age_skill>10)
            {
                age_exploitation -= 3;
                age_skill -= 3;
            }
            if (age_exploitation > 10)
            {
                age_exploitation -= 3;
            }
            if (age_skill > 10)
            {
                age_skill -= 3;
            }
            switch (model)
            {
                case 0:
                    res = cost * power / 100 * age_exploitation * age_skill / 200;
                    if (cost > 1000000)
                    {
                        res = cost * power / 100 * age_exploitation * age_skill / 300;
                    }
                    else if (cost > 2000000)
                    {
                        res = cost * power / 100 * age_exploitation * age_skill / 500;
                    }
                    res = Math.Round(res, 2);
                    break;
                case 1:
                    res = cost * power / 140 * age_exploitation * age_skill / 400;
                    if (cost > 1000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 550;
                    }
                    else if (cost > 2000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 690;
                    }
                    else if (cost > 3000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 800;
                    }
                    else
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 1000;
                    }
                    res = Math.Round(res, 2);
                    break;
                case 2:
                    res = cost * power / 140 * age_exploitation * age_skill / 200;
                    if (cost > 1000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 300;
                    }
                    else if (cost > 2000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 500;
                    }
                    res = Math.Round(res, 2);
                    break;
                case 3:
                    res = cost * power / 140 * age_exploitation * age_skill / 200;
                    if (cost > 1000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 300;
                    }
                    else if (cost > 2000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 500;
                    }
                    res = Math.Round(res, 2);
                    break;
                case 4:
                    res = cost * power / 140 * age_exploitation * age_skill / 200;
                    if (cost > 1000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 300;
                    }
                    else if (cost > 2000000)
                    {
                        res = cost * power / 140 * age_exploitation * age_skill / 500;
                    }
                    res = Math.Round(res, 2);
                    break;
                default:
                    break;
            }
            label6.Text = "Результат: " + res.ToString();

            return res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                textBox1.Text = "1600000";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "3000000";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "250000";
                textBox2.Text = "75";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "760000";
                textBox2.Text = "125";
            }

        }
    }
}
