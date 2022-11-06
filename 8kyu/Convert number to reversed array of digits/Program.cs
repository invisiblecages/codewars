/*
Convert number to reversed array of digits

Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
Example(Input => Output):

35231 => [1,3,2,5,3]
0 => [0]
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      char[] c = n.ToString().ToCharArray();
      long[] arr = new long[c.Length];
      
      for (int i = 0; i < c.Length; i++)
        arr[i] = long.Parse(c[i].ToString());
      
      Array.Reverse(arr);
      return arr;
    }
  }
}