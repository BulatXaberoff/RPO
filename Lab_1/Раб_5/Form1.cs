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
    public partial class Form1 : Form
    {
        int Id = 1;
        public Form1()
        {
            InitializeComponent();
            DataGridViewCell id = new DataGridViewTextBoxCell();
            DataGridViewCell algebra = new DataGridViewTextBoxCell();
            DataGridViewCell matan = new DataGridViewTextBoxCell();
            DataGridViewCell programming = new DataGridViewTextBoxCell();
            DataGridViewCell english = new DataGridViewTextBoxCell();
            DataGridViewCell grant = new DataGridViewTextBoxCell();

            id.Value = Id;
            algebra.Value = 5;
            matan.Value = 5;
            programming.Value = 4;
            english.Value = 4;
            grant.Value = 2300;
            DataGridViewRow row0=new DataGridViewRow();
            row0.Cells.AddRange(id,algebra,matan,programming,english,grant);  
            dataGridView1.Rows.Add(row0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Id++;
            StudentForm stdForm = new StudentForm();
            DialogResult result = stdForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            DataGridViewCell id = new DataGridViewTextBoxCell();
            DataGridViewCell algebra = new DataGridViewTextBoxCell();
            DataGridViewCell matan = new DataGridViewTextBoxCell();
            DataGridViewCell programming = new DataGridViewTextBoxCell();
            DataGridViewCell english = new DataGridViewTextBoxCell();
            DataGridViewCell grant = new DataGridViewTextBoxCell();

            id.Value = stdForm.comboBox5.Text;
            algebra.Value = stdForm.comboBox1.Text;
            matan.Value = stdForm.comboBox2.Text;
            programming.Value = stdForm.comboBox3.Text;
            english.Value = stdForm.comboBox4.Text;
            grant.Value = Grant(stdForm.comboBox1.Text,
                stdForm.comboBox2.Text,
                stdForm.comboBox3.Text,
                stdForm.comboBox4.Text);
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(id, algebra, matan, programming, english, grant);
            dataGridView1.Rows.Add(row);
        }
        int Grant(string alg,string mat,string prog,string engl)
        {
            float a = int.Parse(alg);
            float m = int.Parse(mat);
            float p = int.Parse(prog);
            float e = int.Parse(engl);
            float res = (a + m + p + e) / 20;
            if (res == 1)
            {
                return 5700;
            }
            else if (res < 1 && res > 0.89)
            {
                return 3500;
            }
            else if (res < 0.9 && res >= 0.8)
            {
                return 1700;
            }
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }
    }
}
