/*
Build a function that returns an array of integers from n to 1 where n>0.

Example : n=5 --> [5,4,3,2,1]
*/
public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] numbers = new int[n];
    int num = n;
    
    for (int i = 0; i < n; i++)
      numbers[i] = num--;

    return numbers;
  }
}