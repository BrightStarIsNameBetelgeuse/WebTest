using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSolveTest.Logic;

namespace WebSolveTest
{
    public class ContextSolveStrategy
    {
        ISolveStrategy _solveStrategy;

        public ContextSolveStrategy(ISolveStrategy solveStrategy)
        {
            _solveStrategy = solveStrategy;
        }

        public void SetStrategy(ISolveStrategy strategy)
        {
            _solveStrategy = strategy;
        }

        public double[] Solve(int[,] matrix)
        {
            return _solveStrategy.Solve(matrix);
        }

    }
}