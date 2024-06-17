using System;
using System.Collections;
using System.Collections.Generic;

namespace seesharp_projects
{
  class Program
  {
    static void Main(string[] args)
    {
      var num1 = 0b1001;
      var num2 = 0b01000011;

      System.Console.WriteLine($"Value of Num1 is: {num1}" );
      System.Console.WriteLine($"Value of Num2 is: {num2}");
      System.Console.WriteLine("Char value of Num2 is: {0}", Convert.ToChar(num2));
    }
  }
}