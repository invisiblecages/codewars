/*
A format for expressing an ordered list of integers is to use a comma separated list of either

    individual integers
    or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. 
	The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. 
	For example "12,13,15-17"

Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

Example:

solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
*/
using System.Collections.Generic;

public class RangeExtraction
{
  public static string Extract(int[] args)
  {    
    List<int> nums = new List<int>{args[0]};
    List<string> res = new List<string>();
     
    for (int i = 1; i < args.Length; i++)
    {
      if (args[i] == args[i - 1] + 1)
      { 
        nums.Add(args[i]);
        if (i != args.Length - 1)
          continue;
      }
      
      if (nums.Count == 1)
        res.Add(nums[0].ToString());
      else if (nums.Count == 2)
        res.Add(nums[0] + "," + nums[1]);
      else
        res.Add(nums[0] + "-" + nums[nums.Count - 1]);
        
      if (i == args.Length - 1 && nums[nums.Count - 1] != args[i])
        res.Add(args[i].ToString());

      nums.Clear();
      nums.Add(args[i]);  
    } 

    return string.Join(",", res);
  }
}