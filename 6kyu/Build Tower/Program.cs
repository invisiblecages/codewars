/*
Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

For example, a tower with 3 floors looks like this:

[
  "  *  ",
  " *** ", 
  "*****"
]

And a tower with 6 floors looks like this:

[
  "     *     ", 
  "    ***    ", 
  "   *****   ", 
  "  *******  ", 
  " ********* ", 
  "***********"
]

Math:
https://www.youtube.com/watch?v=KdM6OrvcjPI

	for (int i = 1; i <= n; i++)
	{
	for (int j = 1; j <= (n * 2) - 1; j++)
		if (j >= n - (i - 1) && j <= n + (i - 1))
			Console.Write("*");
		else
			Console.Write(" ");
	
	Console.WriteLine();
	}
*/
public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] arr = new string[nFloors];
    
    for (int i = 0; i < nFloors; i++) 
    {
      for (int j = 0; j < nFloors - i - 1; j++)
        arr[i] += " ";

      for (int k = 0; k < (i * 2) + 1; k++)
        arr[i] += "*";
      
      arr[i] += arr[i].Substring(0, arr[i].Length - (i * 2 + 1));
    }
    
    return arr;
  }
}