using System;
using System.Collections.Generic;

namespace ClusterFig.RandomGenerators
{
    public interface IRandomGenerator<out T> 
    {
        T Generate();
    }
}
