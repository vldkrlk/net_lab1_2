using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_lab1_2
{
    internal class Tab
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        public double f1(double x)
        {
            return Math.Pow(x, 3) - Math.Log(Math.Abs(x) + 1);
        }

        public double f2(double x)
        {
            return (2 * x + 2) / (Math.Tan(2 * x - 1) + 1);
        }

        public double f3(double x)
        {
            return Math.Pow(x, 4) - Math.Pow(x, x);
        }

        public void tabul(double xn = -1.25, double xk = 9.39, double h = 0.4, double a = 0.8)
        {
            double x = xn, y;

            int i = 0;

            while (x <= xk)
            {
                if (x <= 0)
                {
                    y = f1(x);
                }
                else
                {
                    if (x < a)
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }

                xy[i, 0] = x;
                xy[i, 1] = y;

                x = x + h;
                i++;
             }
            n = i;
        }
    }
}
