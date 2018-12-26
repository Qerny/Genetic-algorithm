using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblem
{
    // An interface to solve a task by exhaustive search
    interface IExhaustive<T>
    {
        // Gets set over which the algorithm will work
        T[] GetSet();

        // If the permutation is more optimal than the function
        // must return the higher сoefficient
        int OptimalСoef(T[] perm);
    }
}
