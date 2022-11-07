/*
There is an array with some numbers. All numbers are equal except for one. Try to find it!

findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55

It’s guaranteed that array contains at least 3 numbers.

The tests contain some very huge arrays, so think about performance.

This is the first kata in series:

    Find the unique number (this kata)
    Find the unique string
    Find The Unique
	
	        var tmpBaseInt1 = numbers.First();
            var tmpBaseInt2 = numbers.Skip(1).First();
            var tmpBaseInt3 = numbers.Skip(2).First();
            var tmpBaseInt = 0;

            if (tmpBaseInt1 == tmpBaseInt2 || tmpBaseInt1 == tmpBaseInt3)
            {
                tmpBaseInt = tmpBaseInt1;
            }

            if (tmpBaseInt1 != tmpBaseInt2 && tmpBaseInt1 != tmpBaseInt3)
            {
                return tmpBaseInt1;
            }

            foreach (var i in numbers)
            {
                if (i != tmpBaseInt)
                {
                    return i;
                }
            }
	
	
*/
using System.Collections.Generic;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    
    foreach (int num in numbers)
      if (dictionary.ContainsKey(num))
        dictionary[num] += 1;
      else
        dictionary.Add(num, 1);
    
    foreach (KeyValuePair<int, int> kvp in dictionary)
      if (kvp.Value == 1)
        return kvp.Key;

    return 0;
  }
}