/*
You will be given a list of strings. You must sort it alphabetically (case-sensitive, 
and based on the ASCII values of the chars) and then return the first value.

The returned value must be a string, and have "***" between each of its letters.

You should not remove or add elements from/to the array.
*/
using System;

public class Kata
{
  public static string TwoSort(string[] s)
  {
    if (s.Length == 0)
      return "";
    
    string res = "";
    Array.Sort(s, StringComparer.Ordinal);
    foreach (char c in s[0])
      res += c + "***";
    
    return res.Substring(0, res.Length - 3);
  }  
}