/*
Given a 2-dimensional grid and a zero-based (x,y) coordinate, 
flood-fill the area on the grid containing that coordinate with the given value. 
Two squares in the grid belong to the same area if they contain the same value and are adjacent either horizontally or vertically, 
but not diagonally.

See: https://en.wikipedia.org/wiki/Flood_fill
Grid

The grid is represented as a 2-dimensional rectangular array.
Example

A flood fill with 4 at the point (0, 1) of the following array would look like this:

   [[1, 2, 3],     [[1, 4, 3],
    [1, 2, 2],  ->  [1, 4, 4],
    [2, 3, 2]]      [2, 3, 4]]

Hint

One of the test cases is quite large so make sure your solution is as efficient as possible!
*/
// Iterative BFS
using System.Collections.Generic;

public class Kata
{ 
  public static int[,] FloodFill(int[,] array, int y, int x, int newValue)
  {
    int baseValue = array[y, x];
    bool[,] visited = new bool[array.GetLength(0), array.GetLength(1)];
    Queue<(int, int)> queue = new();
    
    queue.Enqueue((y, x));
    visited[y, x] = true;
    
    while (queue.Count > 0)
    {
      (y, x) = queue.Dequeue();
      
      if (array[y, x] == baseValue)
      {
        array[y, x] = newValue;
 
        if (y > 0 && !visited[y - 1, x])
        {
          queue.Enqueue((y - 1, x));
          visited[y - 1, x] = true;
        }

        if (y < array.GetLength(0) - 1 && !visited[y + 1, x])
        {
          queue.Enqueue((y + 1, x));
          visited[y + 1, x] = true;
        }

        if (x > 0 && !visited[y, x - 1])
        {
          queue.Enqueue((y, x - 1));
          visited[y, x - 1] = true;
        }

        if (x < array.GetLength(1) - 1 && !visited[y, x + 1])
        {
          queue.Enqueue((y, x + 1));
          visited[y, x + 1] = true;
        }
      }
    }
    
    return array;
  }
}

// Recursive DFS - Stack Overflow
public class Kata
{
  
  public static void DFS(int[,] array, int y, int x, int newValue, int baseValue, bool[,] visited)
  {
    if (x < 0 || x > array.GetLength(0) - 1 || y < 0 || y > array.GetLength(1) - 1)
      return;
    if (array[y, x] == newValue || array[y, x] != baseValue)
      return;
    if (visited[y, x])
      return;

    visited[y, x] = true;
    array[y, x] = newValue;
    
    DFS(array, y, x + 1, newValue, baseValue, visited);
    DFS(array, y, x - 1, newValue, baseValue, visited);
    DFS(array, y + 1, x, newValue, baseValue, visited);
    DFS(array, y - 1, x, newValue, baseValue, visited);
  }
}

  public static int[,] FloodFill(int[,] array, int y, int x, int newValue)
  {
    bool[,] visited = new bool[array.GetLength(0), array.GetLength(1)];
    DFS(array, y, x, newValue, array[y, x], visited);
    return array;
  }
}