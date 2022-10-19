/*
Input:

    a string strng
    an array of strings arr

Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):

    a boolean true if all rotations of strng are included in arr
    false otherwise

Examples:

contain_all_rots(
  "bsjq", ["bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"]) -> true

contain_all_rots(
  "Ajylvpy", ["Ajylvpy", "ylvpyAj", "jylvpyA", "lvpyAjy", "pyAjylv", "vpyAjyl", "ipywee"]) -> false)

Note:

Though not correct in a mathematical sense

    we will consider that there are no rotations of strng == ""
    and for any array arr: contain_all_rots("", arr) --> true

Ref: https://en.wikipedia.org/wiki/String_(computer_science)#Rotations
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Rotations
{
  public static Boolean ContainAllRots(string strng, List<string> arr) 
  {
    List<string> stringList = new List<string>();
    
    string str = strng + strng;
    string res = "";
    
    for (int i = 0; i < strng.Length; i++)
    {
      res = str.Substring(1, strng.Length);
      
      if (!stringList.Contains(res))
        stringList.Add(res);
      
      str = res + res;
    } 
 
    for (int i = 0; i < arr.Count; i++)
      if (stringList.Contains(arr[i]))
        stringList.Remove(arr[i]);
    
    return stringList.Count == 0;
  }
}