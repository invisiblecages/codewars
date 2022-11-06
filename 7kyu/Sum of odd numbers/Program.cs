/*
Given the triangle of consecutive odd numbers:

             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...

Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)

1 -->  1
2 --> 3 + 5 = 8
*/
// return (long)Math.Pow(n, 3);
public static class Kata
{
  public static long RowSumOddNumbers(long n)
  {
    long num = n * n - (n - 1);
    long sum = num;
    
    for (int i = 1; i < n; i++)
    {
      num += 2;
      sum += num;    
    }
    
    return sum;
  }
}