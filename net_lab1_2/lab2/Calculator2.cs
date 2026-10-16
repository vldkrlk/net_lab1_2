using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_lab1_2.lab2
{
    public class Calculator2
    {
        int a, b;

        public Calculator2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get; set; }
        public int B { get; set; }

        public int Calculate()
        {
            int result = 1;
            for (int i = a; i <= b; i++)
            {
                if (i % 11 == 0)
                {
                    result *= i;
                }
                if (i % 5 == 2)
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}
