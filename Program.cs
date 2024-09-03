using System;


namespace seesharp_projects
{
  class Program
  {
    static void Main(string[] args)
    {
        var projects = new List<string>();

        projects.Add("BERN");
        System.Console.WriteLine(projects.ToArray());
    }
  }
}
