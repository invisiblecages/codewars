/*
The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

What if the string is empty? Then the result should be empty object literal, {}.
*/
using System;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    var result = new Dictionary<char, int>();
    
    for (int i = 0; i < str.Length; i++)
      if (result.ContainsKey(str[i]))
        result[str[i]] += 1;
      else
        result.Add(str[i], 1);

    var sorted = new SortedDictionary<char, int>(result);
    
    return new Dictionary<char, int>(sorted);
  }
}