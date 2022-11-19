/*
Implement the function unique_in_order which takes as argument a sequence and returns a list of items 
without any elements with the same value next to each other and preserving the original order of elements.

For example:

uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1,2,3}

operator != is undefined for generic T;
EqualityComparer solves this: if (!EqualityComparer<T>.Default.Equals(value1, value2))

Generics:
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.equalitycomparer-1?view=net-7.0
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default
*/
using System.Collections.Generic;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
    List<T> res = new List<T>();
    var tmp = default(T);

    foreach (var item in iterable)
      if (!EqualityComparer<T>.Default.Equals(tmp, item))
      {
        tmp = item;
        res.Add(item);
      }
    
    return res;
  }
}