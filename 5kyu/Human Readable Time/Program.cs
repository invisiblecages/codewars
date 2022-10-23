/*
Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

    HH = hours, padded to 2 digits, range: 00 - 99
    MM = minutes, padded to 2 digits, range: 00 - 59
    SS = seconds, padded to 2 digits, range: 00 - 59

The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.

return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
*/
using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      TimeSpan timespan = TimeSpan.FromSeconds(seconds);
      
      return $"{Math.Floor(timespan.TotalHours):00}:{timespan.Minutes:d2}:{timespan.Seconds:d2}";
    }
}