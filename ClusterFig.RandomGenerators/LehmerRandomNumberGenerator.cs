using System;
using System.Collections;
using System.Collections.Generic;

namespace ClusterFig.RandomGenerators
{
    public class LehmerRandomNumberGenerator: IRandomGenerator<double>
    {
        private const int a = 16807;
        private const int m = 2147483647;
        private const int q = 127773;
        private const int r = 2836;
        private int seed;

        public LehmerRandomNumberGenerator(int seed)
        {
            if (seed <= 0 || seed == int.MaxValue)
                throw new ArgumentException("The seed needs to be greater than zero and less than the max value of int.");
            this.seed = seed;
        }

        public double Generate()
        {
            int hi = seed / q;
            int lo = seed % q;
            seed = (a * lo) - (r * hi);
            if (seed <= 0) seed = seed + m;
            return (seed * 1.0) / m;
        }
    }
}
