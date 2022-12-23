/*
Write a function to get the first element(s) of a sequence. Passing a parameter n (default=1) will return the first n element(s) of the sequence.

If n == 0 return an empty sequence []
Examples

var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
Kata.TakeFirstElements(arr); //=> new object[] { 'a' }
Kata.TakeFirstElements(arr, 2);// => new object[] { 'a', 'b' }
Kata.TakeFirstElements(arr, 3); //=> new object[] { 'a', 'b', 'c' }
Kata.TakeFirstElements(arr, 0); //=> new object[] { }
*/
using System.Linq;

public class Kata
{
  public static object[] TakeFirstElements(object[] array, int n = 1) => array.Take(n).ToArray();
}