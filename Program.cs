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
           static void MyMethod(string fname, int age){
                System.Console.Clear();
                System.Console.WriteLine(fname + " " + age);
           }

            MyMethod("Jason", 31);

            System.Console.WriteLine(AddNumber(2, 1));
    
        }
        public static int AddNumber(int a, int b)
        {
            int sum = a + b;
            return  sum ;
           
        }
    }
}