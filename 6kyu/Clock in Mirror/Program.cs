﻿/*
Peter can see a clock in the mirror from the place he sits in the office. When he saw the clock shows 12:22
1 2 3 4 5 6 7 8 9 10 11 12

He knows that the time is 11:38
1 2 3 4 5 6 7 8 9 10 11 12

in the same manner:

05:25 --> 06:35

01:50 --> 10:10

11:58 --> 12:02

12:01 --> 11:59

Please complete the function WhatIsTheTime(timeInMirror), where timeInMirror is the mirrored time (what Peter sees) as string.

Return the real time as a string.

Consider hours to be between 1 <= hour < 13.

So there is no 00:20, instead it is 12:20.

There is no 13:20, instead it is 01:20.
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string WhatIsTheTime(string timeInMirror)
  {
    string[] arr = timeInMirror.Split(":");
    int hh = 11 - int.Parse(arr[0]);
    int mm = 60 - int.Parse(arr[1]);
    
    if (mm == 60)
    {
      hh++;
      mm = 0;
    }
    
    if (hh < 0)
      hh += 12;
    
    if (hh == 0)
      hh = 12;
    
    return $"{hh:D2}:{mm:D2}";
  }
}