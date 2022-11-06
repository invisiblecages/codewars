/*
Task:

Your task is to write a function which returns the sum of following series upto nth term(parameter).

Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...

Rules:

    You need to round the answer to 2 decimal places and return it as String.

    If the given value is 0 then it should return 0.00

    You will only be given Natural Numbers as arguments.

Examples:(Input --> Output)

1 --> 1 --> "1.00"
2 --> 1 + 1/4 --> "1.25"
5 --> 1 + 1/4 + 1/7 + 1/10 + 1/13 --> "1.57"
*/
using System;

public class NthSeries {
  
  public static string seriesSum (int n) {
    
    if (n == 0)
      return "0.00";
    
    double sum = 1.00;
    double div = 4.00;
    
    for (int i = 0; i < n; i++)
    {
      if (i == 0)
        continue;
      sum += 1.00/(div);
      div += 3;
    }

    return (string.Format("{0:0.00}", sum));
    
  }
}