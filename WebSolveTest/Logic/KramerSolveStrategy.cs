using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSolveTest.Logic
{
    public class KramerSolveStrategy : ISolveStrategy
    {
        private int _varCount;   //количество переменных

        public int VarCount
        {
            get { return _varCount; }
            set { _varCount = value; }
        }

        private int _equatCount; //количество уравнений

        public int EquatCount
        {
            get { return _equatCount; }
            set { _equatCount = value; }
        }

        private Matrix matrixEquat;  

        private int[] determs; //массив определителей
        private int[] coefs; //массив коэффициентов b

        public KramerSolveStrategy(int varCount, int equatCount)
        {
            _varCount = varCount;
            _equatCount = equatCount;        
        }

        public double[] Solve(int[,] matrix)
        {
            if (!isSolve())  //если матрица не квадратная
            {
                return null;
            }

            matrixEquat = new Matrix();
            matrixEquat.SetMatrix(matrix);
            initArrayDeterms();
            double[] result = new double[matrixEquat.Column];
            for (int i = 0; i < matrixEquat.Column; i++)
            {
                result[i] = (double)determs[i] / matrixEquat.GetDeterminant();
            }
            return result;
        }

        public bool isSolve()
        {
            if (_varCount == _equatCount)
                return true;
            return false;
        }

        /// <summary>
        /// Заменить n-й столбец на массив коэффициентов b 
        /// </summary>
        /// <param name="n">номер столбца, который заменяется</param>
        /// <return>Result matrix</return>
        private int[,] replace(int n)
        {
            int[,] tmpMatrix = matrixEquat.GetMatrix();
            for (int i = 0; i < tmpMatrix.GetLength(0); i++)  
            {
                if (i == n) //если дошли до нужного столбца, заменяем 
                {
                    for (int j = 0; j < tmpMatrix.GetLength(0); j++)
                    {
                        tmpMatrix[j, i] = coefs[j];
                    }
                }
            }
            return tmpMatrix;
        }

        //инициализация массива определителей матриц
        private void initArrayDeterms()
        {
            int[,] tmpMatrix = matrixEquat.GetMatrix();
            determs = new int[matrixEquat.Column];
            for (int i = 0; i < matrixEquat.GetMatrix().GetLength(0); i++ )
            {
                determs[i] = matrixEquat.GetDeterminant(replace(i));
            }
        }

    }
}