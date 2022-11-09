/*
Complete the solution so that it splits the string into pairs of two characters. 
If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

Examples:

* 'abc' =>  ['ab', 'c_']
* 'abcdef' => ['ab', 'cd', 'ef']
*/
using System.Collections.Generic;

public class SplitString
{
  public static string[] Solution(string str)
  {
    List<string> arr = new List<string>();
    string res = "";
    
    for (int i = 0; i < str.Length; i++)
    {      
      res += str[i];
      
      if (res.Length == 2)
      {
        arr.Add(res);
        res = "";
      }
      
      if (str.Length % 2 != 0 && i == str.Length - 1)
      { 
        res += "_";
        arr.Add(res);  
      }
    }
    
    return arr.ToArray();
  }
}