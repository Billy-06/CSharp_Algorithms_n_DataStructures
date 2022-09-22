using System;
using System.Collections;

namespace CSharp_Algorithms_n_DataStructures.Algorithms;

public static class ArrayAlgorithms
{
    /**
        <summary>
            The Linear Search searches through the integer array passed, 
            for the interger value of interest.
        </summary>

        <param name="input">
            The Integer Array input to be searched through
        </param>
        <param name="n">
            The integer value of interest
        </param>

        <returns>
            Returns a the interger value enquired about if found 
            otherwise return a null value
        </returns>
    */ 
    public static int? LinearSearch(int[] input, int n)
    {
        foreach(int current in input) 
        {
            if (n == current) return n;
        }
        return null;
    }
    /**
        <summary>
        
        </summary>
        <param name="inputArray">
            The Integer Array input to be searched through
        </param>
        <param name="num">
            The
        </param>
            The integer value of interest
        <returns>
            Returns a true if the integer value of interest is found,
            otherwise returns a false
        </returns>
    */ 
    public static Boolean BinarySearch(int[] inputArray, int num)
    {
        // Assuming the array passed is sorted in an ascending order.
        int min = 0, max = inputArray.Length - 1;
        while(min <= max)
        {
            int mid = (min + max) / 2;
            if (num == inputArray[mid])
            {
                return true;
            }
            else if (num < inputArray[mid])
            {
                max = mid - 1;
            }
            else 
            {
                min = mid + 1;
            }
        }
        return false;
    }
    public static int[] FindEvenNums(int[] arrayOne, int[] arrayTwo)
    {
        ArrayList result = new ArrayList();

        foreach(int number in arrayOne)
        {
            if (number % 2 == 0) result.Add(number);
        }

        foreach(int number in arrayTwo)
        {
            if (number % 2 == 0) result.Add(number);
        }

        return (int[])result.ToArray(typeof(int));
    }

    public static int[] ReverseArray(int[] input)
    {
        int[] reversed = new int[input.Length];

        for(int i = 0; i < input.Length; i++)
        {
            reversed[i] = input[input.Length - i - 1];
        }

        return reversed;
    }
    public static int[] ReversedInPlace(int[] arrayInput)
    {
        for (int i = 0; i < arrayInput.Length/2; i++){
            int temp = arrayInput[i];
            arrayInput[i] = arrayInput[arrayInput.Length - i - 1];
            arrayInput[arrayInput.Length - i - 1] = temp;
        }
        return arrayInput;
    }

    public static int[] RotateArrayLeft(int[] array)
    {
        int temp = array[0];

        for (int i = 0; i < array.Length - 1; i++) array[i] = array[i + 1];

        array[array.Length - 1] = temp;

        return array;
    }
    public static int[] RotateArrayRight(int[] array)
    {
        int temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--) array[i] = array[i - 1];

        array[0] = temp;

        return array;
    }

}