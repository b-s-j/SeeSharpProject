using System;
using System.Collections.Generic;


namespace seesharp_projects
{
    class Program 
    {
       static void Main(string[] args){

        var projects = new List<string>();

        projects.Add("Hello");

        System.Console.WriteLine(projects.First());
       }
    }
}