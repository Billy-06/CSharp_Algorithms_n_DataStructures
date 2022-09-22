using System;
namespace CSharp_Algorithms_n_DataStructures.DesignPatterns;

/**
* 
* > Structs
* > stackalloc -  help you allocate memory on the stack  
*              directly into the stack frame rather than the heap
*              
*              e.g. Span<byte> span = stackalloc byte[128] 
*              keep in mind using stackalloc means our value will not 
*              be garbage collected.
* 
* > ref structs
* > fixed size buffers
* 
* Example
* -------
* 
* [Benchmark]
* [LocalsInt(false)]
* public double VersionStructStackalloc()
* {
 *  for (int i = 0; i < _items.Count; i++)
 * {
 *      data[i].Age = _items[i].Age;
 *      data[i].Gender = Helper(_items[i].Description)
 *                      ? Gender.Female : Gender.Male
 *  }
 *  return ProcessBatch(data);
* }
* 
* */

public class StackBasedData
{
    
}