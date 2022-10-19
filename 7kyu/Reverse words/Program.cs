/*
Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
Examples

"This is an example!" ==> "sihT si na !elpmaxe"
"double  spaces"      ==> "elbuod  secaps"
*/
using System;
using System.Collections;
using System.Text.RegularExpressions;  

public static class Kata
{
  public static string ReverseWords(string str)
  {
    string revStr = "";
    string res = "";

    for (int i = str.Length - 1; i >= 0; i--)
      revStr += str[i];
    
    string[] words = Regex.Split(revStr, "( )");
    
    for (int i = words.Length - 1; i >= 0; i--)
      res += words[i];
    
    return res;
  }
}