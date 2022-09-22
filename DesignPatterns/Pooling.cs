using System;
using System.Collections.Generic;
namespace CSharp_Algorithms_n_DataStructures.DesignPatterns;

/**
 * <summary>
 * Problem: Non-Trivial  cost of creating objects very often.
 * Solution: Instead of creating an object every single time,
 *      we can use object in a pool of objects.
 * 
 * e.g. => ArrayPools
 * Benefits: Smaller GC (Garbage Collection) overhead, no allocation
 *      better data locality
 * Consequences: Trimming policy may be non-trivial 
 *      (The API might become complexx)
 * </summary>
 */
public static class Pooling
{
    public static void PoolingFunction()
    {
        return;
    }
}