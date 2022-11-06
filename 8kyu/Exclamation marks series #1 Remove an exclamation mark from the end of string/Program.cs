/*
Remove an exclamation mark from the end of a string. For a beginner kata, you can assume that the input data is always a string, no need to verify it.
Examples

remove("Hi!") == "Hi"
remove("Hi!!!") == "Hi!!"
remove("!Hi") == "!Hi"
remove("!Hi!") == "!Hi"
remove("Hi! Hi!") == "Hi! Hi"
remove("Hi") == "Hi"
*/
public class Kata
{
  public static string Remove(string s)
  {
	// s.EndsWith("!")
    if (s[s.Length - 1] == '!')
      return s.Substring(0, s.Length - 1);
    else 
      return s;
  }
}