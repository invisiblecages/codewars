/*
Complete the solution so that it strips all text that follows any of a set of comment markers passed in. 
Any whitespace at the end of the line should also be stripped out.

Example:

Given an input string of:

apples, pears # and bananas
grapes
bananas !apples

The output expected would be:

apples, pears
grapes
bananas

The code would be called like so:

string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new [] { "#", "!" })
// result should == "apples, pears\ngrapes\nbananas"
*/
using System;

public class StripCommentsSolution
{
  public static string StripComments(string text, string[] commentSymbols)
  {
    var res = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
    
    for (int i = 0; i < res.Length; i++)
    {
      foreach (var symbol in commentSymbols)
        if (res[i].Contains(symbol))
          res[i] = res[i].Substring(0, res[i].IndexOf(symbol));
      
      res[i] = res[i].TrimEnd();
    }
    
    return string.Join("\n", res);
  }
}