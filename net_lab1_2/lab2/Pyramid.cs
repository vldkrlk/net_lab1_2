using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_lab1_2.lab2
{
    public class Pyramid
    {
        double a, b, h;

        public Pyramid(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }   

        public double A { get; set; }
        public double B { get; set; }
        public double H { get; set; }

        public double volume()
        {
            return (1.0 / 3.0) * a * b * h;
        }

        public double area() {
            double baseArea = a * b;
            double lateralArea = (a * slantHeightA()) + (b * slantHeightB());
            return baseArea + lateralArea;
        }

        public double slantHeightA()
        {
            return Math.Sqrt(Math.Pow(h, 2) + Math.Pow(b / 2.0, 2));
        }

        public double slantHeightB()
        {
            return Math.Sqrt(Math.Pow(h, 2) + Math.Pow(a / 2.0, 2));
        }

    }
}
