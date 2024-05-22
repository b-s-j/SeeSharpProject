using System;

namespace seesharp_projects
{
    class Program 
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The how to of Concurrency in C#");

            string str = "bern";

            Action act= () => System.Console.WriteLine(str);
            act();
            
            Console.ReadLine();
        }
    }
}