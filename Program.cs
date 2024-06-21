using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Net;


namespace seesharp_projects
{
  class Program
  {

    
    static void Main(string[] args)
    {
        Console.WriteLine($"Command Line: {Environment.CommandLine}");
        Console.WriteLine($"Current Directory: {Environment.CurrentDirectory}");
        Console.WriteLine($"Machine Name: {Environment.MachineName}");
        Console.WriteLine($"OS Version: {Environment.OSVersion}");
        Console.WriteLine($"User Name: {Environment.UserName}");
    }
  }
}