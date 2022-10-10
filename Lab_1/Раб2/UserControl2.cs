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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = textBox1.Text.Split(new char[] { ';'});
            int[]arr=new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            int a = arr[0];int b = arr[1]; int c = arr[2];
            triangle(a, b, c);
        }
        void triangle(int a , int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                label3.Text = "Существует";
            }
            else
                label3.Text = "Не существует";
            }
        }
      
    }
