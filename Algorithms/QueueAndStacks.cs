using System;
using System.Collections.Generic;

namespace CSharp_Algorithms_n_DataStructures.Algorithms;

public class QueueAndStacks
{
    public void RunQueueCode()
    {
        Queue<int> myQueue = new Queue<int>();

        myQueue.Enqueue(1);
        myQueue.Enqueue(3);
        myQueue.Enqueue(4);
        myQueue.Enqueue(17);
        myQueue.Enqueue(5);
        myQueue.Enqueue(15);
        myQueue.Enqueue(51);
        myQueue.Enqueue(151);
        myQueue.Enqueue(511);

        int removedItem = myQueue.Dequeue();
        Console.WriteLine($"The removed item is: {removedItem}");
        Console.WriteLine($"The item to be removed is: {myQueue.Dequeue()}");
        Console.WriteLine(myQueue.Dequeue());
        Console.WriteLine($"Taking a Peek into the stack: {myQueue.Peek()}");

        int currentItem;
        while(myQueue.TryDequeue(out currentItem))
        {
            Console.WriteLine($"{currentItem}");
        }
    }

    public void DecimalToBinary(int number)
    {
        List<string> answer = new List<string>();
        int checkValue = number;
        while(checkValue > 0)
        {
                if(checkValue % 2 == 0) answer.Add("0");
                else answer.Add("1");
                checkValue /= 2;
        }

        Console.WriteLine($"Binary form of {number}:");
        for(int i = answer.Count - 1; i >= 0; i-- ) Console.Write($"{answer[i]}");
        Console.WriteLine();
    }
    public void StackDecimalToBinary(int number)
    {
        Stack<int> answer = new Stack<int>();
        int checkValue = number;
        while(checkValue > 0)
        {
                if(checkValue % 2 == 0) answer.Push(0);
                else answer.Push(1);
                checkValue /= 2;
        }
        Console.WriteLine($"Binary form of {number}:");

        foreach(Object item in answer){
            Console.Write($"{item}");
        }
        Console.WriteLine();
    }
    public void NextGreaterElement(int[] myArray)
    {
        if(myArray.Length <= 0) return;

        Stack<int> myStack = new Stack<int>();
        myStack.Push(myArray[0]);

        for(int i = 1; i < myArray.Length; i++)
        {
            int next = myArray[i];
            if(myStack.Count > 0)
            {
                int poppedItem = myStack.Pop();

                while(poppedItem < next)
                {
                    Console.WriteLine($"from {poppedItem} next greater number is -> {next}");
                    if(myStack.Count == 0) break;
                    poppedItem = myStack.Pop();
                }

                if(poppedItem > next) myStack.Push(poppedItem);
            }
            myStack.Push(next);
        }
        foreach(Object item in myStack) Console.WriteLine($"{item} has no next greater number thus output is -1");
    }

    public Boolean HasMatchingParentheses(string myString)
    {
        Stack<char> myStack = new Stack<char>();
        for(int i = 0; i < myString.Length; i++)
        {
            char currentChar = myString[i];

            if (currentChar == '(')
            {
                myStack.Push(currentChar);
                continue;
            }

            if(currentChar == ')')
            {
                if (myStack.Count > 0){
                    myStack.Pop();
                }
                else return false;
            }
        }

        return myStack.Count == 0;
    }
    
    public void AllFunctions()
    {
        Console.WriteLine("Using a naive Function with a List Data Type");
        Console.WriteLine("============================================");
        DecimalToBinary(17);
        DecimalToBinary(34);
        DecimalToBinary(6543);
        Console.WriteLine("Using a Stack Data Type");
        Console.WriteLine("=======================");
        StackDecimalToBinary(17);
        StackDecimalToBinary(34);
        StackDecimalToBinary(6543);

        int[] listOne = { 6,10,71,12,53,18 };
        int[] listTwo = { 6,10,1,12,3,8 };
        int[] listThree = { 99,5,71,12,53,8 };
        int[] listFour = { 6,15,11,12,3,18 };

        int[][] allLists = { listOne, listTwo, listThree, listFour };
        foreach(int[] item in allLists) 
        {
            Console.WriteLine("=================");
            foreach(int integer in item) Console.Write($"{integer},");
            Console.WriteLine();
            Console.WriteLine("=================");
            NextGreaterElement(item);
            Console.WriteLine("=================");
        }

        Console.WriteLine($"((hello)) has matching parentheses? {HasMatchingParentheses("((hello))")}");
        Console.WriteLine($"(hello)) has matching parentheses? {HasMatchingParentheses("(hello))")}");
        Console.WriteLine($"(()(hello)) has matching parentheses? {HasMatchingParentheses("(()(hello))")}");
        Console.WriteLine($"((hel()lo)) has matching parentheses? {HasMatchingParentheses("((hel()lo))")}");

        Console.WriteLine();

        Console.WriteLine($"))hello)) has matching parentheses? {HasMatchingParentheses("))hello))")}");
        Console.WriteLine($")(hello)) has matching parentheses? {HasMatchingParentheses(")(hello))")}");
        Console.WriteLine($"((hello)() has matching parentheses? {HasMatchingParentheses("((hello)()")}");
        Console.WriteLine($"((hel)()lo)) has matching parentheses? {HasMatchingParentheses("((hel)()lo))")}");
        Console.WriteLine($"((hell(so)) has matching parentheses? {HasMatchingParentheses("((hell(so))")}");
    }
}