using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSolveTest.Logic
{
    public interface ISolveStrategy
    {
        double[] Solve(int[,] matrix);
        bool isSolve();
    }
}
