/*
Scenario

Several people are standing in a row divided into two teams.
The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.
Task

Given an array of positive integers (the weights of the people), return a new array/tuple of two integers, 
where the first one is the total weight of team 1, and the second one is the total weight of team 2.
Notes

    Array size is at least 1.
    All numbers will be positive.
    Input >> Output Examples

rowWeights([13, 27, 49])  ==>  return (62, 27)
*/
class Kata
{
    public static int[] RowWeights(int[] a)
    {
      int teamA = 0;
      int teamB = 0;
      
      for (int i = 0; i < a.Length; i++)
      {
        if (i == 0 || i % 2 == 0)
          teamA += a[i];
        else
          teamB += a[i];
      }

      return new int[] { teamA, teamB } ;
    }
}