using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblem
{
    // An interface to solve a task by genetic algorithm
    interface IFintness
    {
        // The number of genes in the genom
        int Arity { get; }

        // The fitness function
        // Returns the higher value if the genom's value is closer to the ideal one
        int Fit(int[] genom);
    }
}
