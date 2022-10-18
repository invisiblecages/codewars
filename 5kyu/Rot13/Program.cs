/*
ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. 
ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. 
If there are numbers or special characters included in the string, they should be returned as they are. 
Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
*/
using System;

public class Kata
{
  public static string Rot13(string message)
  {    
    // a-z = 26
    // a-m + 13
    // n-z - 13
    string res = ""; 
    
    for (int i = 0; i < message.Length; i++)
      if (message[i] >= 'a' && message[i] <= 'm')
        res += Convert.ToChar(message[i] + 13).ToString();
      else if (message[i] >= 'n' && message[i] <= 'z')
        res += Convert.ToChar(message[i] - 13).ToString();
      else if (message[i] >= 'A' && message[i] <= 'M')
        res += Convert.ToChar(message[i] + 13).ToString();
      else if (message[i] >= 'N' && message[i] <= 'Z')
        res += Convert.ToChar(message[i] - 13).ToString();
      else
        res += message[i].ToString();
    
    return res;
  }
}