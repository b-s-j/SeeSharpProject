using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;


namespace seesharp_projects
{
  class Program
  {
    private string color;
    static void Main(string[] args)
    {
      // Acceess Modifiers 
      
      
      Program Mycolor = new Program();
      var magent = ConsoleColor.Green;
      Mycolor.color = magent;

      System.Console.WriteLine(Mycolor.color);
    }
  }

}

