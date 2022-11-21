/*
Create a RomanNumerals class that can convert a roman numeral to and from an integer value. 
It should follow the API demonstrated in the examples below. Multiple roman numeral values will be tested for each helper method.

Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. 
In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; 
or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

Input range : 1 <= n < 4000

In this kata 4 should be represented as IV, NOT as IIII (the "watchmaker's four").
Examples

RomanNumerals.toRoman(1000); // should return 'M'
RomanNumerals.fromRoman('M'); // should return 1000

Help
Symbol 	Value
I 	1
IV 	4
V 	5
X 	10
L 	50
C 	100
D 	500
M 	1000
*/
public class RomanNumerals
{
  private static readonly int M = 1000;
  private static readonly int D = 500;
  private static readonly int C = 100;
  private static readonly int L = 50;
  private static readonly int X = 10;
  private static readonly int V = 5;
  private static readonly int I = 1;
  
  public static string ToRoman(int n)
  {
    string res = "";
    
    while (n > 0)
    {
      if (n - M >= 0)
      {
        res += "M";
        n -= M;
      }
      else if (n - D >= 0)
      {
        res += "D";
        n -= D;     
      }          
      else if (n - C >= 0)
      {
        res += "C";
        n -= C;        
      }
      else if (n - L >= 0)
      {
        res += "L";
        n -= L;     
      }
      else if (n - X >= 0)
      {                
        res += "X";
        n -= X;
      }
      else if (n - V >= 0)
      {
        res += "V";
        n -= V;
      }
      else if (n - I >= 0)
      {
         res += "I";
         n -= I;
      }
      else
        break;
    }
    
    return res
      .Replace("DCCCC", "CM").Replace("CCCC", "CD")
      .Replace("LXXXX", "XC").Replace("XXXX", "XL")
      .Replace("VIIII", "IX").Replace("IIII", "IV");
  }

  public static int FromRoman(string romanNumeral)
  {
    romanNumeral = romanNumeral
      .Replace("CM", "DCCCC").Replace("CD", "CCCC")
      .Replace("XC", "LXXXX").Replace("XL", "XXXX")
      .Replace("IX", "VIIII").Replace("IV", "IIII");
    
    int res = 0;
    
    for (int i = 0; i < romanNumeral.Length; i++)
    {    
      if (romanNumeral[i] == 'M')
        res += M;
      else if (romanNumeral[i] == 'D')
        res += D;
      else if (romanNumeral[i] == 'C')
        res += C;
      else if (romanNumeral[i] == 'L')
        res += L;
      else if (romanNumeral[i] == 'X')
        res += X;
      else if (romanNumeral[i] == 'V')
        res += V;
      else if (romanNumeral[i] == 'I')
        res += I;
      else 
        break;
    }
    
    return res;
  }
}