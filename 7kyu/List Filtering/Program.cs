/*
In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
Example

ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 231}) => {1, 2, 231}
*/
//      return listOfItems.OfType<int>(); 
//      if (x is int) yield return (int) x;
using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
     List<int> res = new List<int>();
     
     foreach (object o in listOfItems)
       if (o is int)
         res.Add((int)o);
     
     return res;
   }
}