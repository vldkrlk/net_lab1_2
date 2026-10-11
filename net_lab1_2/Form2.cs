using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace net_lab1_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            button1.Text = "Назад";

            label1.Text = "N: ";

            button2.Text = "Обрахувати";

            dataGridView1.Columns.Add("op", "Опади");
            dataGridView1.Columns.Add("temp", "Температура");

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

            Array1D op = new Array1D(n, 0, 50);
            Array1D temp = new Array1D(n, -5, 10);

            dataGridView1.Rows.Clear();

            for (int i = 0; i < op.Len; i++)
            {
                dataGridView1.Rows.Add(op[i].ToString(), temp[i].ToString());
            }

            int rain = 0, snow = 0;

            for (int i = 0; i < op.Len; i++)
            {
                if (temp[i] > 0)
                {
                    rain = rain + op[i];
                }
                else if (temp[i] <= 0)
                {
                    snow = snow + op[i];
                }
            }

            label2.Text = "Сніг: " + snow.ToString() + "мм";
            label3.Text = "Дощ: " + rain.ToString() + "мм";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
