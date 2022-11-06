/*
Complete the solution so that the function will break up camel casing, using a space between words.
Example

"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
*/
using System;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    string res = "";
    
    for (int i = 0; i < str.Length; i++)
      if (Char.IsUpper(str[i]))
        res += " " + str[i];
      else
        res += str[i];
    
    return res;
  }
}