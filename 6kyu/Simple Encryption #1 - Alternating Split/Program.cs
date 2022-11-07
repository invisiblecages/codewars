/*
Implement a pseudo-encryption algorithm which given a string S and an integer N concatenates all the 
odd-indexed characters of S with all the even-indexed characters of S, this process should be repeated N times.

Examples:

encrypt("012345", 1)  =>  "135024"
encrypt("012345", 2)  =>  "135024"  ->  "304152"
encrypt("012345", 3)  =>  "135024"  ->  "304152"  ->  "012345"

encrypt("01234", 1)  =>  "13024"
encrypt("01234", 2)  =>  "13024"  ->  "32104"
encrypt("01234", 3)  =>  "13024"  ->  "32104"  ->  "20314"

Together with the encryption function, you should also implement a decryption function which reverses the process.

If the string S is an empty value or the integer N is not positive, return the first argument without changes.
*/
public class Kata
{
  public static string Encrypt(string text, int n)
  {
    if (n < 1 || string.IsNullOrEmpty(text))
      return text;
    
    for (int i = 0; i < n; i++)
    {
      string even = "";
      string odd = "";
      
      for (int j = 0; j < text.Length; j++)
        if (j % 2 == 0)
          even += text[j];
        else
          odd += text[j]; 
      
      text = odd + even;
    }

    return text;
  }
  
  public static string Decrypt(string encryptedText, int n)
  {
    if (n < 1 || string.IsNullOrEmpty(encryptedText))
      return encryptedText;

    string text = "";
    string firstHalf = encryptedText.Substring(0, encryptedText.Length / 2);
    string secondHalf = encryptedText.Substring(encryptedText.Length / 2);
    
    for (int i = 0; i < n; i++)
    {
      text = "";
      
      for (int j = 0; j < encryptedText.Length / 2; j++)
      {
        text += secondHalf[j];
        text += firstHalf[j];
      }
      
      if (firstHalf.Length != secondHalf.Length)
        text += secondHalf[secondHalf.Length - 1];
      
      firstHalf = text.Substring(0, encryptedText.Length / 2);
      secondHalf = text.Substring(encryptedText.Length / 2);
    }

    return text;
  }
}