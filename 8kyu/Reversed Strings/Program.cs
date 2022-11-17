/*
Complete the solution so that it reverses the string passed into it.

'world'  =>  'dlrow'
'word'   =>  'drow'
*/
public static class Kata
{
  public static string Solution(string str) 
  {
    string res = "";
    for (int i = str.Length - 1; i >= 0; i--)
      res += str[i];
    
    return res;
  }
}