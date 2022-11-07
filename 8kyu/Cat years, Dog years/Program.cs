/*
Kata Task

I have a cat and a dog.

I got them at the same time as kitten/puppy. That was humanYears years ago.

Return their respective ages now as [humanYears,catYears,dogYears]

NOTES:

    humanYears >= 1
    humanYears are whole numbers only

Cat Years

    15 cat years for first year
    +9 cat years for second year
    +4 cat years for each year after that

Dog Years

    15 dog years for first year
    +9 dog years for second year
    +5 dog years for each year after that


	Math operation is much faster:
	https://github.com/kvarcas91/Codewars-Solutions-and-Benchmarks/blob/master/Bench/Kata8/Benchmarks/CatYearsDogYears.md
	int dogYear = 15 + (humanYears >= 2 ? 9 + 5 * (humanYears - 2) : 0);
*/
public class Dinglemouse 
{
  public static int[] humanYearsCatYearsDogYears(int humanYears) 
  {
    int catYears = 0, dogYears = 0;
    
    for (int i = 0; i < humanYears; i++)
      if (i == 0)
      { 
        catYears += 15;
        dogYears += 15;        
      }
      else if (i == 1)
      {
        catYears += 9;   
        dogYears += 9;        
      }
      else
      {
        catYears += 4;
        dogYears += 5;
      }
    
    return new int[] { humanYears, catYears, dogYears };
  }
}