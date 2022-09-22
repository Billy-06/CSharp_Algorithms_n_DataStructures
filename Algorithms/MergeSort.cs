using System;
namespace CSharp_Algorithms_n_DataStructures.Algorithms;

public class MergeSort : BasicAlgorithm
{

    
    public MergeSort()
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
}