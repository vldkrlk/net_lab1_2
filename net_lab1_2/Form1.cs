using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace net_lab1_2
{
    public partial class Form1 : Form
    {
        private Tab tab;
        public Form1()
        {
            InitializeComponent();

            tab = new Tab();

            label1.Text = "Xn";
            label2.Text = "Xk";
            label3.Text = "h";
            label4.Text = "a";

            button1.Text = "Обрахувати";

            textBox1.Text = "-1,25";
            textBox2.Text = "9,39";
            textBox3.Text = "0,4";
            textBox4.Text = "0,8";

            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Legends.Clear();

            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xn, xk, h, a;

            xn = Convert.ToDouble(textBox1.Text);
            xk = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            a = Convert.ToDouble(textBox4.Text);

            dataGridView1.Rows.Clear();

            chart2.Series[0].Points.Clear();

            tab.tabul(xn, xk, h, a);

            for (int i = 0; i < tab.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tab.xy[i, 0],2).ToString(),
                      Math.Round(tab.xy[i, 1],2).ToString());
                chart2.Series[0].Points.AddXY(tab.xy[i, 0], tab.xy[i, 1]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
