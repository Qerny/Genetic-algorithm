using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinArea
{
    // Provides an interface to get permutations
    public interface IPermutations<T>
    {
        // Generates N! of permutations from given set and
        // for every permutation calls a callback function
        void Generate(T[] set, Action<T[]> callback);
    }

    // Implements the interface generating permutations recursivly
    public class Permutations<T> : IPermutations<T>
    {
        private T[] _set;
        private Action<T[]> _callback = null;

        public void Generate(T[] set, Action<T[]> callback)
        {
            _set = new T[set.Length];
            set.CopyTo(_set, 0);
            _callback = callback;
            GenerateRec(0, _set.Length);
        }

        // Generates permutations recursivly
        private void GenerateRec(int k, int n)
        {
            if (k == n)
            {
                _callback?.Invoke(_set);
            }
            else
            {
                for (int i = k; i < n; ++i)
                {
                    Utils.Swap(ref _set[i], ref _set[k]);
                    GenerateRec(k + 1, n);
                    Utils.Swap(ref _set[i], ref _set[k]);
                }
            }
        }
    }
}
