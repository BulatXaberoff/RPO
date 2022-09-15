using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var res = Math.Sqrt(Convert.ToDouble(num_textbox.Text));
            if (res == double.NaN)
            {
                MessageBox.Show("Неверные введенные значения\n" + num_textbox.Text);
                return;
            }
            MessageBox.Show("Результат\n" + Convert.ToString(res));

        }
    }
}
