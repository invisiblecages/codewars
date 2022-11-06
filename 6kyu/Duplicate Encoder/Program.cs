/*
The goal of this exercise is to convert a string to a new string where each character in the new string is 
"(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. 
Ignore capitalization when determining if a character is a duplicate.

Examples:
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 

Assertion messages may be unclear about what they display in some languages. 
If you read "...It Should encode XXX", the "XXX" is the expected result, not the input!
*/
using System.Collections.Generic;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    Dictionary<char, int> dictionary = new Dictionary<char, int>();
    string res = "";
    
    foreach (char c in word.ToLower())
      if (!dictionary.ContainsKey(c))
        dictionary.Add(c, 1);
      else
        dictionary[c] += 1;
    
    foreach (char c in word.ToLower())
      if (dictionary.GetValueOrDefault(c) == 1)
        res += "(";
      else
        res += ")";  

    return res;
  }
}