using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void get_result_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(num_textbox.Text);
                double b = Convert.ToDouble(pow_textbox.Text); ;
                res_textbox.Text = Convert.ToString(Math.Pow(a, b));
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные параметры");
            }
            
        }
    }
}
