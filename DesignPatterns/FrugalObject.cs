using System;
namespace CSharp_Algorithms_n_DataStructures.DesignPatterns;

/**
 * <summary>
 * Frugal Object
 * Problem: We need to efficiently store data that can take different forms
 * 
 * Solution: Instead of creating an object for each form separately, created
 * some kind of a discriminated union
 * Benefit: Uses less memory and has better data locality. Better JIT optimisation
 * </summary>
 */
public readonly struct StringValue
{

}

public class FrugalObject
{
    public static void RunClass()
    {
        return;
    }
}