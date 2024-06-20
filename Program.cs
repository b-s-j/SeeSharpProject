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
      // C# Program to find the ip address of the machine 
      string hostname = Dns.GetHostName();
      System.Console.WriteLine(hostname);

      string IP = Dns.GetHostEntry(hostname).AddressList[0].ToString();
      System.Console.WriteLine("Ip Address is: " + IP);
      
    }
  }
}