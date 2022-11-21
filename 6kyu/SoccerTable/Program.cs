/*
Do you like soccer :)

You have a result table for several teams, and there is also a face-to-face match result. 
You need to write a method to return the new table after applying the result in the table.

The table is like this:

TeamName Game Win Draw Loss  Point
----------------------------------
Arsenal   3    2   0    1     6
City      5    2   2    1     8
Rome      1    0   1    0     1

The new result is in this String form:

"Arsenal 0:2 Rome"

The new table should be like this:

Arsenal   4    2   0    2     6
City      5    2   2    1     8
Rome      2    1   1    0     4

The winner get 3 points Draw gives both teams 1 points

TableRow is class like this:

public class TableRow
    {
        public string TeamName { get; set; }
        public int Game { get; set; }
        public int Point { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Loss { get; set; }
    }

You don't need to rank them in the return table.
*/
using System;
using System.Collections.Generic;

namespace Soccer 
{
  public class Kata
  {
    public static List<TableRow> InjectNewResult(string newResult, List<TableRow> table)
    {
      if (String.IsNullOrEmpty(newResult) || table == null || table.Count < 2)
        return table;
      
      string[] arr = newResult.Replace(":", " ").Split();
      
      if (arr.Length < 4)
        return table;
      
      string teamA = arr[0], teamB = arr[3];
      int scoreA = int.Parse(arr[1]), scoreB = int.Parse(arr[2]);

      foreach (var team in table)
      {
        if (scoreA == scoreB && (teamA == team.TeamName || teamB == team.TeamName))
        {
          team.Game++;
          team.Draw++;
          team.Point++;
        }
        else if (scoreA > scoreB && teamA == team.TeamName || scoreB > scoreA && teamB == team.TeamName)
        {  
          team.Game++;
          team.Win++;
          team.Point += 3;
        }
        else if (scoreA < scoreB && teamA == team.TeamName || scoreB < scoreA && teamB == team.TeamName)
        {  
          team.Game++;
          team.Loss++;
        }
        else
          continue;
      }

      return table;
    }
  }
}