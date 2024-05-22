using System;

namespace seesharp_projects
{
    class Program 
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your name: ");
            string? name = Console.ReadLine();

            System.Console.WriteLine($"Hello {name}");

        }
    }
}