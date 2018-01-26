using System;
using System.Runtime.CompilerServices;

namespace ClusterFig.RandomGenerators
{
    public class LinearCongruentialRandomNumberGenerator: IRandomGenerator<double>
    {
        private const long a = 25214903917;
        private const long c = 11;
        private long seed;

        public LinearCongruentialRandomNumberGenerator(long seed)
        {
            if (seed < 0)
                throw new ArgumentException("The seed needs to be equal or greater than zero.");
            this.seed = seed;
        }

        public double Generate()
        {
            return (((long)next(26) << 27) + next(27)) / (double)(1L << 53);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int next(int bits)
        {
            seed = (seed * a + c) & ((1L << 48) - 1);
            return (int)(seed >> (48 - bits));
        }
    }
}
