using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSolveTest.Logic
{
    public class GaussSolveStrategy : ISolveStrategy
    {
        protected int _varCount;   //количество переменных

        public int VarCount
        {
            get { return _varCount; }
            set { _varCount = value; }
        }

        protected int _equatCount; //количество уравнений

        public int EquatCount
        {
            get { return _equatCount; }
            set { _equatCount = value; }
        }

        public GaussSolveStrategy(int varCount, int equatCount)
        {
            _varCount = varCount;
            _equatCount = equatCount;
        }

        public void Solve()
        {
            throw new NotImplementedException();
        }

        public double[] Solve(int[,] matrix)
        {
            throw new NotImplementedException();
        }

        public bool isSolve()
        {
            throw new NotImplementedException();
        }
    }
}