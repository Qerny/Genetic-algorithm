using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblem
{
    // The travel salesman task
    class Travel : IFintness, IExhaustive<int>
    {
        static private readonly int BITS_PER_CITY = 32;

        //The count of the cities
        public int CountCities { get; private set; } = 4;

        //The matrix of adjacency
        private int[,] _matrix;

        // The pair with key as the number of the city
        private Pair[] _pairs;

        //The current path
        private int[] _path;

        // A constructor
        public Travel(int[,] matr, int count)
        {
            _matrix = matr;
            CountCities = count;

            _pairs = new Pair[CountCities];
            _path = new int[CountCities];
            for (int i = 0; i < CountCities; ++i)
            {
                _pairs[i] = new Pair();
            }
        }

        ///The size of the genom in bits
        public int Arity => CountCities * BITS_PER_CITY;

        // Get the path length by the number of the cities
        public int GetPathLen(int[] citiesNums)
        {
            bool[] visited = new bool[CountCities];
            int len = 0;
            for (int i = 0; i < citiesNums.Length - 1; ++i)
            {
                if (visited[citiesNums[i]])
                    return -1;

                visited[citiesNums[i]] = true;
                len += _matrix[citiesNums[i], citiesNums[i + 1]];
            }
            if (visited[citiesNums[citiesNums.Length - 1]])
                return -1;

            len += _matrix[citiesNums[citiesNums.Length - 1], citiesNums[0]];
            return len;
        }

        // The fitness function
        public int Fit(int[] genom)
        {
            var path = FormPath(genom);
            int len = GetPathLen(path);
            return len == -1 ? 0 : int.MaxValue - len;
        }

        // Forms a path by a given genome
        public int[] FormPath(int[] genom)
        {
            // for every city set the appropriate gene in natural order
            for (int i = 0; i < CountCities; ++i)
            {
                _pairs[i].Key = i;
                _pairs[i].Value = genom[i];
            }

            // sort pairs by the value of the genes
            Array.Sort(_pairs);
            
            // make a path by the next rule:
            // if the value of the gene of the city is less then
            // the city is going earler in the order
            for (int i = 0; i < genom.Length; ++i)
            {
                //path[i] = genom[i] % CountCities;                 
                _path[i] = _pairs[i].Key;
            }            
            return _path;
        }

        // Gets the set of the numbers of the cities
        public int[] GetSet()
        {
            var citieNums = new int[CountCities];
            for (int i = 0; i < CountCities; ++i)
            {
                citieNums[i] = i;
            }
            return citieNums;
        }

        // Gets koefficient for permutation algorithms
        public int OptimalСoef(int[] perm)
        {
            int len = GetPathLen(perm);
            return int.MaxValue - len;
        }
    }    
}
