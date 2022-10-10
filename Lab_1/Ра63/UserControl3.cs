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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        string Conv(string str, int from, int to)
        {
            return Convert.ToString(Convert.ToInt32(str, from), to);
        }
        private void get_result_Click_1(object sender, EventArgs e)
        {
            try
            {
                var s = num_textbox.Text.Split(new char[] { ';' });
                res_textbox.Text = Conv(s[0], Convert.ToInt32(s[1]), Convert.ToInt32(pow_textbox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные");
            }
        }
    }
}
