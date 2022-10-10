using ForPractice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Раб2
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix m = new Matrix(3, 3);
                m[0, 0] = double.Parse(textBox1.Text);
                m[0, 1] = double.Parse(textBox2.Text);
                m[0, 2] = double.Parse(textBox5.Text);

                m[1, 0] = double.Parse(textBox3.Text);
                m[1, 1] = double.Parse(textBox4.Text);
                m[1, 2] = double.Parse(textBox6.Text);

                m[2, 0] = double.Parse(textBox7.Text);
                m[2, 1] = double.Parse(textBox8.Text);
                m[2, 2] = double.Parse(textBox9.Text);
                if (radioButton1.Checked)
                {
                    var ob = m.Transposition();
                    MessageBox.Show($"Траспонированная матрица:\n{ob}");
                }
                if (radioButton2.Checked)
                {
                    var det = m.Determinant();
                    MessageBox.Show($"Определитель равен: {det}");
                }
                if (radioButton3.Checked)
                {
                    var ob = m.InverseMatrix();
                    MessageBox.Show($"Обратная матрица:\n{ob}");
                    MessageBox.Show($"{m}*\n{ob}=\n{m*ob}");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
