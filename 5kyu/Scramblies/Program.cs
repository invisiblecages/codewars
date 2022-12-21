/*
Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

Notes:

    Only lower case letters will be used (a-z). No punctuation or digits will be included.
    Performance needs to be considered.

Examples

scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
*/
using System;

public class Scramblies 
{
  public static bool Scramble(string str1, string str2) 
  {    
    int count = 0;
    foreach (var c in str2)
      if (str1.Contains(c))
      {
        str1 = str1.Remove(str1.IndexOf(c), 1);
        count++;
      }
    
    return str2.Length == count;
  }
}