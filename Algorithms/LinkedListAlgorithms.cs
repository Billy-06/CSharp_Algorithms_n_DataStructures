using System;
using System.Collections.Generic;

namespace CSharp_Algorithms_n_DataStructures.Algorithms;

class LinkedListAlgorithms
{

    public void RunEntry(){
        LinkedList<string> linkedList =  new LinkedList<string>();

        Console.WriteLine("====================================");
        Console.WriteLine("Using Linked Lists");
        Console.WriteLine("====================================");
        Console.WriteLine("Person 1 -> Person 2 -> Person 3 -> Person 4 -> Person 5 -> Person 6 ->");
        Console.WriteLine("====================================");
        linkedList.AddLast("Person 1");
        linkedList.AddLast("Person 2");
        linkedList.AddLast("Person 3");
        linkedList.AddLast("Person 4");
        linkedList.AddLast("Person 5");
        linkedList.AddLast("Person 6");

        Console.WriteLine($"LinkedList contains Person 3? {linkedList.Contains("Person 3")}");
        Console.WriteLine($"Size of the Linked List: {linkedList.Count()}");
        Console.WriteLine("====================================");

    }
}