using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_lab1_2
{
    internal class Array2D
    {
        public bool error = false;
        int rows = 5;
        int cols = 5;
        private int[,] a;

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }

        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < rows && 0 <= j && j < cols)
                {
                    return a[i, j];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < rows && 0 <= j && j < cols && value >= -50 && value <= 50)
                {
                    a[i, j] = value;
                }
                else
                {
                    error = true;
                }
            }
        }
        void generate()
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = rand.Next(-50, 50);
                }
            }
        }

        public Array2D(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            a = new int[rows, cols];
            generate();
        }

        public Array2D()
        {
            a = new int[rows, cols];
            generate();
        }
    }
}
