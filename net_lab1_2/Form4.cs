using net_lab1_2.lab2;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            lab2.Calculator1 calculator = new lab2.Calculator1(a, b, c);

            int result = calculator.Calculate();

            label4.Text = "Результат: " + result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lab2.Calculator2 calculator = new lab2.Calculator2(
                Convert.ToInt32(textBox5.Text),
                Convert.ToInt32(textBox4.Text));

            int result = calculator.Calculate();

            label8.Text = "Результат: " + result.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pyramid p = new Pyramid(
                Convert.ToDouble(textBox6.Text),
                Convert.ToDouble(textBox7.Text),
                Convert.ToDouble(textBox8.Text));

            double volume = Math.Round(p.volume(), 3);
            double area = Math.Round(p.area(), 3);
            double sa = Math.Round(p.slantHeightA(), 3);
            double sb = Math.Round(p.slantHeightB(), 3);

            label12.Text = "Площа: " + area.ToString();
            label13.Text = "Об'єм: " + volume.ToString();
            label14.Text = "Апофема (А): " + sa.ToString();
            label15.Text = "Апофема (B): " + sb.ToString();

        }
    }
}
