using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace seesharp_projects
{
    class Program 
    {
        static void Main(string[] args)
        {
           // Create an ArrayList class included in the System.Collections ]

           List<string> list = new List<string>();

           list.AddRange(new string[] { "Bern", "Joe", "Smith", "Anne",});
        
          var minimm =   list.MinBy(x => x.Length);
          var maximm =  list.MaxBy(x => x.Last(x => x.CompareTo(x) > 0));

        


           foreach (string s in list){
            System.Console.WriteLine(s);
           }

        }
    }
}