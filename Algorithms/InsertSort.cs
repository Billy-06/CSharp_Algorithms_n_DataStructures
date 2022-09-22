using System;
namespace CSharp_Algorithms_n_DataStructures.Algorithms;

public class BasicAlgorithm{
    protected int[] _listOfIntegers;
    protected int[] _ascendingList;
    protected int[] _descendingList;

    public BasicAlgorithm()
    {
        var randomHandler = new Random();
        _listOfIntegers = new int[45];
        for(int i = 0; i < 40; i++)
        {
            _listOfIntegers[i] = randomHandler.Next(-400, 400);
        }
        _ascendingList = _listOfIntegers;
        _descendingList = _listOfIntegers;
    }
    protected void PrintAsc()
    {
        foreach(var item in _ascendingList)
        {
            Console.WriteLine(item);
        }

    }
    protected void PrintDes()
    {
        foreach(var item in _descendingList)
        {
            Console.WriteLine(item);
        }

    }
}

public class InsertSort : BasicAlgorithm{
    
    
    public int[] IntList {
        get { return _listOfIntegers; }
        set { _listOfIntegers = value; }
    }
    public int[] Ascend(){
        for(int i = 1; i < _ascendingList.Length; i++)
        {
            int currentValue = _ascendingList[i];
            int j = i - 1;
            while( j >= 0 && currentValue < _ascendingList[j] )
            {
                _ascendingList[j + 1] = _ascendingList[j];
                _ascendingList[j] = currentValue;
                if (j > 0) j--;
            }
        }

        return _ascendingList;
    }
    public int[] Descend(){
        for(int i = 1; i < _descendingList.Length; i++)
        {
            int currentValue = _descendingList[i];
            int j = i - 1;
            while( j >= 0 && currentValue > _descendingList[j] )
            {
                _descendingList[j + 1] = _descendingList[j];
                _descendingList[j] = currentValue;
                if (j > 0) j--;
            }
        }

        return _descendingList;
    }

    public void Ascending(string command){
        if (command.ToLower() == "print" )
        {
            Console.WriteLine("Printing the results");
        }
        int[] _ascendingList = _listOfIntegers;
        for(int i = 1; i < _ascendingList.Length; i++)
        {
            int currentValue = _ascendingList[i];
            int j = i - 1;
            while( j > 0 && currentValue < _ascendingList[j] )
            {
                _ascendingList[j + 1] = _ascendingList[j];
                _ascendingList[j] = currentValue;
                j--;
            }
        };
        PrintAsc();
    }
    public void Descending(){
        
        for(int i = 1; i < _descendingList.Length; i++)
        {
            int currentValue = _descendingList[i];
            int j = i - 1;
            while( j > 0 && currentValue > _descendingList[j] )
            {
                _descendingList[j + 1] = _descendingList[j];
                _descendingList[j] = currentValue;
                j--;
            }
        };
        PrintDes();
    }

    private static void Print(int[] someList){
        foreach(var item in someList) Console.Write($"{item}, ");
        Console.WriteLine("\n");
    }

    public void RunInsert()
    {
        Console.WriteLine("Beginning the Insert Sort");
        Console.WriteLine("Unsorted List: ");
        Print(this.IntList);
        Console.WriteLine("Ascending Order List:");
        Print(this.Ascend());
        Console.WriteLine("Descending Order List:");
        Print(this.Descend());
        Console.WriteLine("End Insert Sort Algorithm");
        Console.WriteLine("============================");
    }

    public InsertSort()
    {
        var randomHandler = new Random();
        _listOfIntegers = new int[45];
        for(int i = 0; i < 40; i++)
        {
            _listOfIntegers[i] = randomHandler.Next(-400, 400);
        }
        _ascendingList = _listOfIntegers;
        _descendingList = _listOfIntegers;
    }
    public InsertSort(int[] ListOfInts)
    {
        _listOfIntegers = ListOfInts;
        _ascendingList = _listOfIntegers;
        _descendingList = _listOfIntegers;

    }
    
    
}