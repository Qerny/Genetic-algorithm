using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblem
{
    // The genetic algorithm
    class GeneticBase
    {
        static private readonly int BIT_PER_GEN = 32;

        //The fitness function
        private IFintness _fintness;

        //The length of the genom in  bits
        private int _genomLength;

        // The count gens per genom
        // A one gene has 'BIT_PER_GEN' bits
        private int _countGens;

        //The parent
        private int[][] _parentGenoms;

        //The children
        private int[][] _childrenGenoms;

        //Random generator
        private Random random = new Random();

        //Time checker
        private ITimeCheck _timeCheck;

        //The count of generation due to working algorithm
        public int CountGenerations { get; set; }

        //The count of children in every generation
        public int CountEntitiesInGeneration { get; set; }

        //Whether mutations will be used
        public bool UseMutation { get; set; }

        //The frequency of mutations
        public double MunationPercent { get; set; }

        public GeneticBase(IFintness fintness, ITimeCheck timeCheck = null)
        {
            _fintness = fintness;
            _genomLength = fintness.Arity;
            _countGens = (int) Math.Ceiling((double)_genomLength / BIT_PER_GEN);
            _timeCheck = timeCheck;
        }

        // The tournament selection
        private void DoSelection()
        {
            // for every children
            for (int i = 0; i < CountEntitiesInGeneration; ++i)
            {
                // choose two random parents
                int ind1 = random.Next(CountEntitiesInGeneration);
                int ind2 = random.Next(CountEntitiesInGeneration);

                // take the value of the fitnes finction
                int fr1 = _fintness.Fit(_parentGenoms[ind1]);
                int fr2 = _fintness.Fit(_parentGenoms[ind2]);

                // set to the current children the selected parent
                // with the best value of the fitness function
                _childrenGenoms[i] = fr1 > fr2 ? (int[])_parentGenoms[ind1].Clone() :
                    (int[])_parentGenoms[ind2].Clone();                
            }
        }

        // Crosses two genoms
        private void CrossGenoms(int[] genom1, int[] genom2)
        {
            for (int i = 0; i < _countGens; ++i)
            {
                int mask = random.Next();
                int swapMask = (genom1[i] ^ genom2[i]) & mask;
                genom1[i] ^= swapMask;
                genom2[i] ^= swapMask;
            }
        }

        // Crosses children generation
        private void CrossGeneration()
        {
            for (int i = 0; i < CountEntitiesInGeneration / 2; ++i)
            {
                int ind1 = i * 2;
                int ind2 = ind1 + 1;
                CrossGenoms(_childrenGenoms[ind1], _childrenGenoms[ind2]);
            }
        }

        // Mutate genom randomly
        private void MutateGenom(int[] genom)
        {
            // change one bit in genom
            int ind = random.Next(_countGens);
            int offset = random.Next(BIT_PER_GEN);
            int mask = 1 << offset;
            genom[ind] ^= mask;
        }

        // Mutates children generation
        private void MutateGeneration()
        {
            foreach (var genom in _childrenGenoms)
            {
                if (random.NextDouble() <= MunationPercent)
                    MutateGenom(genom);
                
            }
        }

        // Creates random genom
        private int[] GenerateRandomGenom()
        {
            var res = new int[_countGens];
            for (int i = 0; i < res.Length; ++i)
            {
                res[i] = random.Next();
            }
            return res;
        }

        // Creates the first generation of parents
        private void CreateFirstGeneration()
        {
            for (int i = 0; i < _parentGenoms.Length; ++i)
            {
                _parentGenoms[i] = GenerateRandomGenom();
            }
        }

        // Starts the algorithm
        public int[] Run()
        {
            _parentGenoms = new int[CountEntitiesInGeneration][];
            _childrenGenoms = new int[CountEntitiesInGeneration][];

            _timeCheck?.Start();

            CreateFirstGeneration();

            for (int currGen = 0; currGen < CountGenerations; ++currGen)
            {
                DoSelection();
                CrossGeneration();
                if (UseMutation)
                    MutateGeneration();

                var tmp = _parentGenoms;
                _parentGenoms = _childrenGenoms;
                _childrenGenoms = tmp;
            }

            // choose the best genom
            int bestFitness = 0;
            int[] bestGenom = null;
            foreach (var genom in _parentGenoms)
            {
                int fitRes = _fintness.Fit(genom);
                if (fitRes > bestFitness)
                {
                    bestFitness = fitRes;
                    bestGenom = genom;
                }
            }

            _timeCheck?.Stop();

            return bestGenom;
        }
    }
}
