/*
Write Number in Expanded Form

You will be given a number and you will need to return it as a string in Expanded Form. For example:

Kata.ExpandedForm(12); # Should return "10 + 2"
Kata.ExpandedForm(42); # Should return "40 + 2"
Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"

NOTE: All numbers will be whole numbers greater than 0.
*/
using System.Collections.Generic;

public static class Kata 
{
  public static string ExpandedForm(long num) 
  {
    List<long> nums = new List<long>();
    long pv = 1;
    
    while (num > 0)
    {
      long digit = num % pv;
      
      if (digit != 0)
        nums.Add(digit);
        
      num -= digit;
      pv *= 10;
    }
    
    nums.Reverse();
    return string.Join(" + ", nums);
  }
}