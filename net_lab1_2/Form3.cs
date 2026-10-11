using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_lab1_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.Text = "Назад";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);

            Array2D arr = new Array2D(n, m);

            DataGridViewTextBoxColumn column;

            for (int i = 0; i < arr.Cols; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column.Width = 30;
                dataGridView1.Columns.Add(column);
            }
            dataGridView1.Rows.Clear();

            dataGridView1.RowCount = arr.Rows;
            dataGridView1.ColumnCount = arr.Cols;

            int product = 1;

            for (int i = 0; i < arr.Rows; i++)
            {
                for (int j = 0; j < arr.Cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();

                    if (i > j)
                    {
                        product *= arr[i, j];
                    }
                }
            }

            label3.Text = "Добуток: " + product.ToString();
        }
    }
}
