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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var C = double.Parse(textBox1.Text);
                var res = C * 1.8 + 32.0;
                label3.Text = res.ToString() + "°F";
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные");
            }
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Подсказка: Формула перевода Цельсий (°C) в Фаренгейт (°F)\nПример: 10°C x 1, 8 + 32 = 50°F");
        }
    }
}
