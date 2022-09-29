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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int salary = int.Parse(textBox1.Text);
                label2.Text = "Ваша зарплата с учетом НДФЛ: " + salary * 0.87;
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }
    }
}
