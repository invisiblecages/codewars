/*
You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. 
We want to create the text that should be displayed next to such an item.

Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

[]                                -->  "no one likes this"
["Peter"]                         -->  "Peter likes this"
["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"

Note: For 4 or more names, the number in "and 2 others" simply increases.
*/
using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    string[] likedBy = name;
    int count = 0;
    
    for (int i = 0; i < name.Length; i++)
    {
      likedBy[i] = name[i];
      count++;
    }

    if (likedBy.Length == 1)
      return $"{likedBy[0]} likes this";
    else if (likedBy.Length == 2)
      return $"{likedBy[0]} and {likedBy[1]} like this";
    else if (likedBy.Length == 3)
      return $"{likedBy[0]}, {likedBy[1]} and {likedBy[2]} like this";
    else if (likedBy.Length >= 4)
      return $"{likedBy[0]}, {likedBy[1]} and {count-2} others like this";    

    return "no one likes this";
  }
}