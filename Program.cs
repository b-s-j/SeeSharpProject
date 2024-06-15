using System;
using System.Collections.Generic;

namespace seesharp_projects
{
  class Program
  {
    static void Main(string[] args)
    {
      int counter = 0;
      do
      {
        Console.WriteLine(counter);
        counter++;
      } while (counter <= 10);


     int length = 10;

      for (int i = 0; 
                i < length; 
                i++
          )
      {
        System.Console.WriteLine(i);
      }
    }
  }
}