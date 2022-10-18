/*
Given a string of words, you need to find the highest scoring word.

Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

You need to return the highest scoring word as a string.

If two words score the same, return the word that appears earliest in the original string.

All letters will be lowercase and all inputs will be valid.
*/
public class Kata
{
  public static string High(string s)
  {
    string[] words = s.Split(" ");
    string res = "";
    int sum = 0;
    int temp = 0;
    
    for (int i = 0; i < words.Length; i++)
    {
      sum = 0;
      
      for (int j = 0; j < words[i].Length; j++)
      {
        switch (words[i][j])
        {
          case 'a': sum += 1; break;
          case 'b': sum += 2; break;
          case 'c': sum += 3; break;
          case 'd': sum += 4; break;
          case 'e': sum += 5; break;
          case 'f': sum += 6; break;
          case 'g': sum += 7; break;
          case 'h': sum += 8; break;
          case 'i': sum += 9; break;
          case 'j': sum += 10; break;
          case 'k': sum += 11; break;
          case 'l': sum += 12; break;
          case 'm': sum += 13; break;
          case 'n': sum += 14; break;
          case 'o': sum += 15; break;
          case 'p': sum += 16; break;
          case 'q': sum += 17; break;
          case 'r': sum += 18; break;
          case 's': sum += 19; break;
          case 't': sum += 20; break;
          case 'u': sum += 21; break;
          case 'v': sum += 22; break;
          case 'w': sum += 23; break;
          case 'x': sum += 24; break;
          case 'y': sum += 25; break;
          case 'z': sum += 26; break;
        }
      }
      
      if (sum > temp) 
      {
        res = words[i];
        temp = sum;
      }
    }
    
    return res;
  }
}