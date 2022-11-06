/*
Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. 
You will always be given an array with five six-sided dice values.

 Three 1's => 1000 points
 Three 6's =>  600 points
 Three 5's =>  500 points
 Three 4's =>  400 points
 Three 3's =>  300 points
 Three 2's =>  200 points
 One   1   =>  100 points
 One   5   =>   50 point

A single die can only be counted once in each roll. 
For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

Example scoring

 Throw       Score
 ---------   ------------------
 5 1 3 4 1   250:  50 (for the 5) + 2 * 100 (for the 1s)
 1 1 1 3 1   1100: 1000 (for three 1s) + 100 (for the other 1)
 2 4 4 5 4   450:  400 (for three 4s) + 50 (for the 5)

In some languages, it is possible to mutate the input to the function. This is something that you should never do. 
If you mutate the input, you will not be able to pass all the tests.
*/
using System;

public static class Kata
{
  public static int Score(int[] dice) {
    
    int sum = 0, ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0;
    
    for (int i = 0; i < dice.Length; i++) 
    {
      switch (dice[i]) 
      {
          case 1:
            ones++;
            break;
          case 2:
            twos++;
            break;
          case 3:
            threes++;
            break;
          case 4:
            fours++;
            break;
          case 5:
            fives++;
            break;
          case 6:
            sixes++;
            break;
          default:
            break;
      }
    }
    
    if (ones > 0 && ones < 3 ) sum += ones * 100;
    else if (ones == 3) sum += 1000;
    else if (ones == 4) sum += 1100;
    else if (ones == 5) sum += 1200;
    
    if (twos >= 3) sum += 200;
    if (threes >= 3) sum += 300;
    if (fours >= 3) sum += 400;

    if (fives > 0 && fives < 3 ) sum += fives * 50;
    else if (fives == 3) sum += 500;
    else if (fives == 4) sum += 550;
    else if (fives == 5) sum += 600;
    
    if (sixes >= 3) sum += 600;
    
    return sum;
  }
}