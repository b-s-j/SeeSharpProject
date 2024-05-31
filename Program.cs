using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace seesharp_projects
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool canIvote = true;

            System.Console.WriteLine($"Biggest integer:  { 0 }", int.MaxValue);
            System.Console.WriteLine($"Biggest integer:  { 0 }", int.MinValue);
            
            System.Console.WriteLine("Biggest long: {0}", long.MaxValue);
            System.Console.WriteLine("Biggest long: {0}", long.MinValue);

            decimal Pi = 3.14159262342342242342343M;
            System.Console.WriteLine(Pi);
        }
    }
}