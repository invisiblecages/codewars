/*
Write a function which calculates the average of the numbers in a given list.

Note: Empty arrays should return 0.
*/
//    return array.Average();
class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    if (array.Length == 0)
      return 0;
    
    double avg = 0;
    foreach (double number in array)
      avg += number;
    
    return avg/array.Length;
  }
} 