/*
Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of the integer's divisors(except for 1 and the number itself), from smallest to largest. If the number is prime return the string '(integer) is prime' (null in C#) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).
Example:

Kata.Divisors(12) => new int[] {2, 3, 4, 6};
Kata.Divisors(25) => new int[] {5};
Kata.Divisors(13) => null;
*/
using System.Collections.Generic;

public class Kata
{
  public static int[] Divisors(int n)
  {
    List<int> res = new List<int>();
    
    for (int i = 2; i < n; i++)
      if  (n % i == 0)
        res.Add(i);
    
    if (res.Count > 0)
      return res.ToArray();
    else
      return null;
  }
}