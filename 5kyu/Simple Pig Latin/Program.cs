/*
Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
Examples

Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
*/
using System.Text.RegularExpressions;

public class Kata
{
  public static string PigIt(string str)
  {
    string res = "";
    string[] words = str.Split();
    Regex regex = new Regex(@"^[a-z]", RegexOptions.IgnoreCase);
    
    for (int i = 0; i < words.Length; i++)
      if (regex.IsMatch(words[i]))
        res += words[i].Substring(1, words[i].Length - 1) + words[i].Substring(0, 1) + "ay ";
      else
        res += words[i].Substring(1, words[i].Length - 1) + words[i].Substring(0, 1) + " ";
    
    return res.Substring(0, res.Length - 1);
  }
}