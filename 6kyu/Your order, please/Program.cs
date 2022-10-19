/*
Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
Examples

"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
""  -->  ""
*/
using System;
using System.Text.RegularExpressions;  

public static class Kata
{
  public static string Order(string words)
  {
    if (words == null)
      return "";
    
    string index = Regex.Replace(words.ToLower(), @"[^0-9]", "");
    int[] indexArray = new int[index.Length];
    
    for (int i = 0; i < index.Length; i++)
      indexArray[i] = Convert.ToInt32(index[i] - '0');
     
    string[] wordArray = words.Split();
    string[] res = new string[wordArray.Length];
    
    int tempIndex;
    
    for (int i = 1; i <= indexArray.Length; i++)
    {
      tempIndex = Array.IndexOf(indexArray, i);
      res[i-1] = wordArray[tempIndex];
    }
    
    return String.Join(" ", res);
  }
}