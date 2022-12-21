/*
Write a function that takes a string of braces, and determines if the order of the braces is valid. 
It should return true if the string is valid, and false if it's invalid.

This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. Thanks to @arnedag for the idea!

All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.
What is considered Valid?

A string of braces is considered valid if all braces are matched with the correct brace.
Examples

"(){}[]"   =>  True
"([{}])"   =>  True
"(}"       =>  False
"[(])"     =>  False
"[({})](]" =>  False
*/

// First solution
using System;

public class Brace 
{
  public static bool validBraces(String braces)
  {
    if (braces.Length == 1)
      return false;
    
    while (braces.Contains("()") || braces.Contains("[]") || braces.Contains("{}"))
      braces = braces.Replace("()", "").Replace("[]", "").Replace("{}", "");
    
    return braces.Length == 0;
  }
}

// Alternative solution
public class Brace 
{
  public static bool isValid(string braces)
  {
    if (braces.Length == 1)
      return false;
    
    var dict = new Dictionary<char, char>
    { 
      { '(', ')' },
      { '[', ']' }, 
      { '{', '}' } 
    };
    var stack = new Stack<char>();
    
    foreach (var c in braces)
      if (dict.ContainsKey(c))
        stack.Push(c);
      else if (c != dict[stack.Pop()])
          return false;
		  
    return stack.Count == 0;
  }
}