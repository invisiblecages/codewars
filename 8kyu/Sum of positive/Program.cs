﻿/*
You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.
*/
//    return arr.Where(x => x > 0).Sum();
using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] > 0)
        sum += arr[i];
    }
      if (sum > 0)
        return sum;
       else
         return 0;
  }
}