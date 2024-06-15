using System;
using System.Collections.Generic;


namespace seesharp_projects
{
    class Program 
    {
       static void Main(string[] args)
       {
         Random random = new Random();
        bool playAgain = true;
        int min = 1; 
        int max = 100;
        int guess;
        int number;
        int guesses;

        while (playAgain){
          guess = 0;
          guesses = 0;
          number = random.Next(min, max + 1);

          while(guess != number){
           System.Console.Write($"Guess a number between  {min} - {max} : ");
           guess = Convert.ToInt32(Console.ReadLine());
           System.Console.WriteLine($"Guess: {guess}");

           if (guess > number){
            System.Console.WriteLine($"{guess} is too high!");
           }else if(guess < number){
            System.Console.WriteLine($"{guess} is too low!");
           }
           guesses++;
          }
          System.Console.WriteLine($"Number: {number}");
          System.Console.WriteLine($"You Win!");
          System.Console.WriteLine($"Guesses: {guesses}");
        }
        System.Console.WriteLine();
        
       }
    }
}