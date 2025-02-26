using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MyMatrix
    {
        private int[,] matrix;
        private int rows;
        private int cols;

        public MyMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[rows, cols];
            FillMatrix();
        }

        private void FillMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Resize(int newRows, int newCols)
        {
            int[,] newMatrix = new int[newRows, newCols];
            for (int i = 0; i < Math.Min(rows, newRows); i++)
            {
                for (int j = 0; j < Math.Min(cols, newCols); j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            matrix = newMatrix;
            rows = newRows;
            cols = newCols;
        }
    }

  

}
