/*
Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 
0 is neither positive nor negative.

If the input is an empty array or is null, return an empty array.
Example

For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
      if (input == null || input.Length == 0)
        return new int[0];
      
      int posSum = 0, negSum = 0;
      
      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] > 0)
          posSum++;
        else
          negSum += input[i];
      }
      return new int[] { posSum, negSum };
    }
}