/*
Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
*/
public class Kata
{
  public static int FindShort(string s)
  {
    string[] words = s.Split(" ");
    int res = int.MaxValue;
    
    foreach (string str in words)
      if (str.Length < res)
        res = str.Length;
      
    return res;
  }
}