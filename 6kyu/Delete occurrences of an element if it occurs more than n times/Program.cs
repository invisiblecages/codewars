/*
Enough is enough!

Alice and Bob were on a holiday. Both of them took many pictures of the places they've been, 
and now they want to show Charlie their entire collection. However, Charlie doesn't like these sessions, since the motif usually repeats. 
He isn't fond of seeing the Eiffel tower 40 times.
He tells them that he will only sit for the session if they show the same motif at most N times. Luckily, Alice and Bob are able to encode the motif as a number. 
Can you help them to remove numbers such that their list contains each number only up to N times, without changing the order?

Task

Given a list and a number, create a new list that contains each number of list at most N times, without reordering.
For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], drop the next [1,2] 
since this would lead to 1 and 2 being in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
With list [20,37,20,21] and number 1, the result would be [20,37,21].


Better solution:
        var occurences = new Dictionary<int, int>();
        var list = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(!occurences.ContainsKey(arr[i])) occurences.Add(arr[i], 1);
            else occurences[arr[i]]++;
            if(occurences[arr[i]] <= x) list.Add(arr[i]);
        }
        return list.ToArray();
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata 
{
  public static int[] DeleteNth(int[] arr, int x) 
  {
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    List<int> res = arr.ToList();
    
    foreach (int i in res)
      if (dictionary.ContainsKey(i))
        dictionary[i]++;
      else
        dictionary.Add(i, 1);
    
    foreach(KeyValuePair<int, int> kvp in dictionary)
      if (kvp.Value > x)
        for (int i = 0; i < (kvp.Value - x); i++)
          res.RemoveAt(res.LastIndexOf(kvp.Key));
    
    return res.ToArray();
  }
}