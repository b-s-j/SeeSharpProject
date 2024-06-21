using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Net;


namespace seesharp_projects
{
  class Program
  {

    
    static void Main(string[] args)
    {
      // shorthand if else statement conditionals
        int saleAmount = 900;
        int discount = saleAmount > 1000? 100 : 50;
        Console.WriteLine($"Discount: {discount}");
    }
  }
}

