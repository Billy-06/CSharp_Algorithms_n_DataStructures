using System;
using CSharp_Algorithms_n_DataStructures;
using CSharp_Algorithms_n_DataStructures.DesignPatterns;
using CSharp_Algorithms_n_DataStructures.Algorithms;



public class Program{
    private static void Print(int[] someList){
        foreach(var item in someList)
        {
            Console.WriteLine(item);
        }
    }

    public static string ReverseAlter(string input)
    {
        
        if(string.IsNullOrEmpty(input)) return input;
        if(input.Split(" ").Length > 1);

        char[] characters = input.ToCharArray();
        Array.Reverse(characters);

        return new String(characters);
    }

    

    static void Main(string[] args){
        int[] randomList = { 34, 45, 56, 78, 90 };

        InsertSort Sorter = new();
        Sorter.RunInsert();

        LinkedListAlgorithms myList = new();
        myList.RunEntry();

        QueueAndStacks myObject = new();
        myObject.AllFunctions();
        
    }
}