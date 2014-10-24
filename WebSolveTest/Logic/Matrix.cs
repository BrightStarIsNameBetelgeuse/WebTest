using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSolveTest.Logic
{
    /// <summary>
    /// Class that implements the matrix
    /// </summary>
    public class Matrix
    {
        private int row, column;

        /// <summary>
        /// Count of rows
        /// </summary>
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        /// <summary>
        /// Count of columns
        /// </summary>
        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        private int[,] matr;

        public Matrix() { }

        public void SetMatrix(int[,] matrix)
        {
            row = matrix.GetLength(0);
            column = row;
            matr = matrix;
        }

        private int CalcDeterm(int[,] matr)
        {
            if (matr.Length == 4)   //when second-order matrix
            {
                return matr[0, 0] * matr[1, 1] + matr[0, 1] * matr[1, 0];
            }
            int sign = 1, result = 0;
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                int[,] minor = GetMinore(matr, i);
                result += sign * matr[0, i] * CalcDeterm(minor);
                sign = -sign;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matr">The initial matrix</param>
        /// <param name="n"> Dimension of the minor</param>
        /// <returns></returns>
        private int[,] GetMinore(int[,] matr, int n)
        {
            int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(0) - 1];
            for (int i = 1; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < n; j++)
                    result[i - 1, j] = matr[i, j];
                for (int j = n + 1; j < matr.GetLength(0); j++)
                    result[i - 1, j - 1] = matr[i, j];
            }
            return result;
        }

        /// <summary>
        /// Get the determinant of the matrix
        /// </summary>
        /// <returns></returns>
        public int GetDeterminant()
        {
            return CalcDeterm(matr);
        }

        public int GetDeterminant(int[,] matrix)
        {
            return CalcDeterm(matrix);
        }

        public int[,] GetMatrix()
        {
            return matr;
        }

    }
}