/*
Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.
Examples:

Input: 42145 Output: 54421

Input: 145263 Output: 654321

Input: 123456789 Output: 987654321
*/
using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    string nums = num.ToString();
    int[] numsArray = new int[nums.Length];
    
    for (int i = 0; i < nums.Length; i++)
      numsArray[i] = nums[i] -'0';
    
    Array.Sort(numsArray);
    Array.Reverse(numsArray);
    
    string res = "";
    
    for (int i = 0; i < numsArray.Length; i++)
      res += numsArray[i].ToString();
    
    return Int32.Parse(res);
  }
}