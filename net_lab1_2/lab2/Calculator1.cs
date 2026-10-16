using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_lab1_2.lab2
{
    public class Calculator1
    {
        int a, b, c;

        public Calculator1(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Calculator1()
        {
            a = 0;
            b = 0;
            c = 0;
        }


        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public int Calculate()
        {
            int sum = a + b + c;
            int result;

            if ( a > 5 || b > 5 || c > 5)
            {
                result = (int)Math.Pow(sum, 3);
            }
            else
            {
                result = sum;
            }
            return result;
        }
    }
}
