/*
You get an array of arrays.
If you sort the arrays by their length, you will see, that their length-values are consecutive.
But one array is missing!


You have to write a method, that return the length of the missing array.

Example:
[[1, 2], [4, 5, 1, 1], [1], [5, 6, 7, 8, 9]] --> 3


If the array of arrays is null/nil or empty, the method should return 0.

When an array in the array is null or empty, the method should return 0 too!
There will always be a missing element and its length will be always between the given arrays.
*/
using System;

public class Kata
{
  public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
  {
    if (arrayOfArrays == null || arrayOfArrays.Length == 0)
      return 0;
    
    int[] arr = new int[arrayOfArrays.Length];
    
    for (int i = 0; i < arrayOfArrays.Length; i++)
      if (arrayOfArrays[i] == null || arrayOfArrays[i].Length == 0)
        return 0;
      else
        arr[i] = arrayOfArrays[i].Length;
    
    Array.Sort(arr);
    
    for (int i = 0; i < arr.Length - 1; i++)
      if (arr[i] + 1 != arr[i + 1])
        return arr[i] + 1;
    
    return 0;
  }
}