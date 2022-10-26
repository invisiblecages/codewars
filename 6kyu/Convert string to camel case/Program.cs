/*
Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).
Examples

"the-stealth-warrior" gets converted to "theStealthWarrior"
"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

            var words = str.Split('-','_');
            for (int i = 1; i < words.Length; i++)
            {
              words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i]);
            }
            return String.Join("", words);
*/
// This breaks if str = "someThing_"; or str = "some_-thing";
public class Kata
{
  public static string ToCamelCase(string str)
  {
    string res = "";
    
    for (int i = 0; i < str.Length; i++)
    {
      if (str[i] == '-' || str[i] == '_')
        res += str[++i].ToString().ToUpper();
      else
        res += str[i].ToString();
    }
    
    return res;
  }
}