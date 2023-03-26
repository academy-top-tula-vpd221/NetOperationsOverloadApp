using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOperationsOverloadApp
{
    internal class Matrix
    {
        public int Rows { set; get; }
        public int Columns { set; get; }
        int[,] matrix;
        public Matrix(int rows = 0, int columns = 0)
        {
            Rows = rows;
            Columns = columns;
            matrix = new int[rows, columns];
        }
        public int this[int row, int col] 
        {
            get => matrix[row, col];
            set => matrix[row, col] = value;
        }
        
    }
}
