/*
You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this "outlier" N.
Examples

[2, 4, 0, 100, 4, 11, 2602, 36]
Should return: 11 (the only odd number)

[160, 3, 1719, 19, 11, 13, -21]
Should return: 160 (the only even number)

Optimal solution:

Your algorithm is wrong: odds and evens do not represent lists of odd and even numbers; instead, they represent a single-element list containing the last odd or even value found.

When you run your program on the first example, odds is [3] and evens is [-10] (the last odd and the last even number, correspondingly). Your if condition is structured in such a way as to prefer evens to odds, explaining the return.

Since the problem is set in such a way that there is always only one outlier, you do not need additional collections at all. You can structure your algorithm in this way:

    Take the first three numbers (the problem guarantees that there's going to be at least three)
    Count the number of odds among the first three numbers
    Count the number of evens among the first three numbers
    If you have more odds than evens, then find and return the first even number
    If you have more evens than odds, then find and return the first odd number

Here is a simple implementation:

int firstThreeParity = integers[0] % 2 + integers[1] % 2 + integers[2] % 2;
int rem = firstThreeParity < 2 ? 1 : 0;
for (int i = 0; i < integers.length; i++) {
    if (integers[i] % 2 == rem) {
        return integers[i];
    }
}
return -1; // If the input is correct, we'll never reach this line
*/
public class Kata
{
  public static int Find(int[] integers)
  {
    int oddCount = 0;
    int oddNum = 0;
    int evenCount = 0;
    int evenNum = 0;

    for (int i = 0; i < integers.Length; i++)
      if (integers[i] % 2 == 0)
      {
        ++evenCount;
        evenNum = integers[i];
      }
      else
      {
        ++oddCount;
        oddNum = integers[i];
      }

    if (oddCount < evenCount)
      return oddNum;
    else
      return evenNum;
  }
}