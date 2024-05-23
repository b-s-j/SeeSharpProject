using System;

namespace seesharp_projects
{
    class Program 
    {
        static void Main(string[] args)
        {
            // trying to print a simple callendar 
            // Hingin ang taon mula sa user
            Console.Write("Please enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Hingin ang buwan mula sa user
            Console.Write("Please enter the month (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            // Kunin ang unang araw ng buwan
            DateTime firstDayOfMonth = new DateTime(year, month, 1);

            // I-print ang header ng kalendaryo
            Console.WriteLine("Mo Tu We Th Fr Sa Su");

            // Kalkulahin ang unang araw ng linggo ng buwan ok this is it 
            int dayOfWeek = (int)firstDayOfMonth.DayOfWeek;

            // I-adjust ang dayOfWeek para magsimula sa Lunes (1) imbes na Linggo (0)
            dayOfWeek = (dayOfWeek == 0) ? 7 : dayOfWeek;

            // Gumamit ng for loop para mag-print ng mga blanko hanggang sa unang araw
            for (int i = 1; i < dayOfWeek; i++)
            {
                Console.Write("   ");
            }

            // Gumamit ng for loop para mag-print ng mga araw ng buwan
            for (int day = 1; day <= DateTime.DaysInMonth(year, month); day++)
            {
                Console.Write(day.ToString().PadLeft(2, ' ') + " ");

                // Kapag natapos na ang isang linggo, magpalit ng linya
                if ((day + dayOfWeek - 1) % 7 == 0)
                    Console.WriteLine();
            }
        }
    }
}