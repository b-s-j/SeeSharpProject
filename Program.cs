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

           ArrayList arlist = new ArrayList();

           var Barlist = new ArrayList();

           Barlist.Add("John");

           Barlist.Add(1);
           Barlist.Add(2);
           Barlist.Add(3);
           Barlist.Add(4);

           foreach (var item in Barlist){
                Console.WriteLine(item.ToString());
           }

        }
    }
}