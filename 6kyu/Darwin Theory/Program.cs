/*
#Darwin Theory

The story of this Kata is similar to Darwin Theory.
There is a class named "Creature" and you are supposed to complete the class. Any instance of this class is a creature.

Lets say:

Creature balineseCat = new Creature();

balineseCat is a cat that you have created and you are the True God.

You have to be able to assign your creature properties by use of indexer, for example:

balineseCat["Eye"]="Blue";

It is not the whole story yet.
Suppose you create a fish:

Creature fish= new Creature();

give it the ability to survive in water:

fish["gill"]=true;

Then you create a frog:

Creature frog= new Creature();

The frog can automatically survive in water, and you don't need to modify it further.
If you give him lung to breathe in air and drop the gill:

frog["lung"]=true;
frog["gill"]=false;

The next creature you will create can automatically breathe in air with the lung.

P.S. The properties that are assigned by indexers can be in any type.
Test cases clarify the problem.
Take a look at MSDN to get more help about indexers:
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/?redirectedfrom=MSDN
*/
using System.Collections.Generic;

public class Creature
{
  private static readonly Dictionary<string, object> properties = new();
  
  public object this[string property]
  {
    get { return properties[property]; }
    set { properties[property] = value; }
  }
}