/*
Given an array of integers, find the one that appears an odd number of times.

There will always be only one integer that appears an odd number of times.
Examples

[7] should return 7, because it occurs 1 time (which is odd).
[0] should return 0, because it occurs 1 time (which is odd).
[1,1,2] should return 2, because it occurs 1 time (which is odd).
[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
*/
using System.Collections.Generic;

namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {            
      Dictionary<int, int> dictionary = new Dictionary<int, int>();
      
      for (int i = 0; i < seq.Length; i++)
        if (dictionary.ContainsKey(seq[i]))
          dictionary[seq[i]]++;
        else
          dictionary.Add(seq[i], 1);

      foreach (KeyValuePair<int, int> kvp in dictionary)
        if (kvp.Value % 2 != 0)
          return kvp.Key;

      return -1;
    }
  }
}