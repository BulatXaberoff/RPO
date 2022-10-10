using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ра63
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var a = double.Parse(textBox1.Text);
                var b = double.Parse(textBox2.Text);
                var c = double.Parse(textBox3.Text);

                var d = Math.Pow(b, 2) - 4 * a * c;
                double x1, x2, x;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    MessageBox.Show($"x1= {x1}\n" +
                                    $"x2= {x2}");
                }
                else if (d == 0)
                {

                    x = -b / (2 * a);
                    MessageBox.Show($"x= {x}");
                }
                else
                    MessageBox.Show("Решения нет");
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно");
            }
        }
    }
}
