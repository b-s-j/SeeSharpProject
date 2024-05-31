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
            System.Console.Clear();
            System.Console.WriteLine("Currency: {0:c}", 23.455);
            System.Console.WriteLine("Pad with 0's: {0:d5}", 23);
            System.Console.WriteLine("3 Decimals: {0:f3}", 23.45555);
            System.Console.WriteLine("Commas: {0:n4}", 2355);
        }
    }
}