/*
Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.
Examples:

a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
*/
using System;
using System.Linq;

public class TwoToOne
{
  public static string Longest (string s1, string s2) 
  {
    char [] chars = (s1 + s2).Distinct().ToArray();
    Array.Sort(chars);
    
    return new string(chars);
  }
}