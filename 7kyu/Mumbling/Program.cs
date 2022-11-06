/*
This time no story, no theory. The examples below show you how to write function accum:
Examples:

accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"

The parameter of accum is a string which includes only letters from a..z and A..Z.
*/
using System;

public class Accumul 
{
  public static String Accum(string s) 
  {
    string str = s.ToLower();
    string result = "";
    
    for (int i = 0; i < str.Length; i++) 
    {
      for (int j = 0; j <= i; j++) 
      {
        if (j == 0)
          result += str[i].ToString().ToUpper();
        else
          result += str[i];
      }
      if (i + 1 < str.Length)
        result += "-";
    }
    return result;
  }
}