using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace net_lab1_2
{
    internal class Array1D
    {
        public bool error = false;

        int[] a;
        int len;

        public int Len
        {
            get { return len; }
            set { len = value; }
        }

        public int this[int i]
        {
            get
            {
                if (0 <= i && i < len)
                {
                    return a[i];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < len && value >= -50 && value <= 50)
                {
                    a[i] = value;
                }
                else
                {
                    error = true;
                }
            }
        }
        public Array1D() 
        { 
            a = new int[len];
        }

        public Array1D(int[] arr)
        {
            a = arr;
        }

        public Array1D(int size, int from, int to)
        {
            len = size;
            a = new int[len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                a[i] = rand.Next(from, to);
            }
        }
    }
}
