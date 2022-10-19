/*
Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b keeping their order.

Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}

If a value is present in b, all of its occurrences must be removed from the other:

Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
*/

// Best practice
// With a hashset, we won't have to iterate over b for every item in a.
// Instead, we can check if an item exists in constant time
//	HashSet<int> bSet = new HashSet<int>(b);
//	return a.Where(v => !bSet.Contains(v)).ToArray();

using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    List<int> newArray = new List<int>();
    
    for (int i = 0; i < a.Length; i++)
    {
      bool match = false;
      for (int j = 0; j < b.Length; j++)
        if(a[i] == b[j])
        {
          match = true;
          break;
        }
      if (!match)
        newArray.Add(a[i]);
    }
    
    return newArray.ToArray();
  }
}