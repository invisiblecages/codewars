/*
Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

Note: input will never be an empty string
*/
using System;
using System.Linq;

public class Kata
{
  public static string FakeBin(string x)
  {
    int[] nums = new int[x.Length];
    
    for (int i = 0; i < x.Length; i++)
      nums[i] = Convert.ToInt32(x[i] - '0');
    
    for (int i = 0; i < nums.Length; i++)
      if (nums[i] < 5)
        nums[i] = 0;
      else
        nums[i] = 1;

    return string.Join("", nums);
  }
}