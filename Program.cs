using System;
using System.Collections;
using System.Collections.Generic;

namespace seesharp_projects
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = new List<string> 
      {
        "Scott",
        "Anna",
        "Tommy",
        "jerry"
      };

      names.Add("David");
      names.Add("Damian");
      names.Add(@$"{names}");

      foreach (var name in names){
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}