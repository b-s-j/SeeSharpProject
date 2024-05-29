using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace seesharp_projects
{
    class Program 
    {
        static void Main(string[] args)
        {
           // Create an ArrayList class included in the System.Collections ]

           List<string> list = [.. new string[] { "Bern", "Joe", "Smith", "Anne",}, .. new string[] {"Jessie", "Terry", "Chitos", "Tume"}];

            var names = new List<string> {
                "mAmA", "Joph", "Rea",
            };
           var startingWith_M = names.Where(x => x.StartsWith("m"));

            var startingWith_F = names.Where(x => x.StartsWith("f"));

            
            // updating existing list
            names[0] = "ford";

            // Guess what should be printed before continuing
            print( startingWith_M.ToList() );
            print( startingWith_F.ToList() );

           foreach (string s in list){
            System.Console.WriteLine(s);
           }

        }
    }
}