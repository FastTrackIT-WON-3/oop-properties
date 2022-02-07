using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProperties
{
    public class MyMatrix
    {
        private readonly int[,] matrix;

        public MyMatrix(int[,] elements)
        {
            matrix = elements ?? new int[0, 0];
        }

        public int this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }
    }
}
