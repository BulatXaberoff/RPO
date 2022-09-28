using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Раб_5
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var cb in Controls.OfType<ComboBox>())
            {
                if (cb.Text=="")
                {
                    MessageBox.Show("Заполнено не все");
                    break;
                }
            }
            
        }


    }
}
