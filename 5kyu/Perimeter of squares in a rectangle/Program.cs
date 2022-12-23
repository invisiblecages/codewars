/*
The drawing shows 6 squares the sides of which have a length of 1, 1, 2, 3, 5, 8. 
It's easy to see that the sum of the perimeters of these squares is : 4 * (1 + 1 + 2 + 3 + 5 + 8) = 4 * 20 = 80 

Could you give the sum of the perimeters of all the squares in a rectangle when there are n + 1 squares disposed in the same manner as in the drawing:
http://i.imgur.com/EYcuB1wm.jpg

Hint:

See Fibonacci sequence
Ref:

http://oeis.org/A000045

The function perimeter has for parameter n where n + 1 is the number of squares (they are numbered from 0 to n) 
and returns the total perimeter of all the squares.

perimeter(5)  should return 80
perimeter(7)  should return 216
*/
using System;
using System.Numerics;

public class SumFct
{
  public static BigInteger perimeter(BigInteger n) 
  {
    n += 2;
    BigInteger num1 = 0;
    BigInteger num2 = 1;
    BigInteger sum = 0;
    BigInteger res = num1 + num2;
    
    for (BigInteger i = 2; i < n; i++)
    {
      sum = num1 + num2;
      res += sum;
      num1 = num2;
      num2 = sum;
    }
    
    return 4 * res;
  }
}