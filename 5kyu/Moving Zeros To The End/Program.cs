/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int newIndex = 0;

    for (int i = 0; i < arr.Length; i++)
      if (arr[i] != 0)
        arr[newIndex++] = arr[i];
    
    while (newIndex < arr.Length)
      arr[newIndex++] = 0;
    
    return arr;        
  }
}