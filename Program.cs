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
           
            var names = new string [] { "Scott", "Anna", "Felipe"};
            names = [..names, "Anne", "Damian", "Bern",];

            foreach (var name in names)
            {
                System.Console.WriteLine("" + name[^2]);
            }
        }
    }
}