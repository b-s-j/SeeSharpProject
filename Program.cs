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
            int number = -27; // You can change this number to any integer you want to convert
            string words = NumberToWordConverter.NumberToWords(number);
            Console.WriteLine(words);
          
        }

        public static class NumberToWordConverter
        {
            private static readonly string[] UnitsMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            private static readonly string[] TensMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            public static string NumberToWords(int number)
            {
                if (number == 0)
                    return UnitsMap[0];

                if (number < 0)
                    return "Negative " + NumberToWords(Math.Abs(number));

                var words = new StringBuilder();

                words.Append(ProcessGroup(number / 1000000000, "Billion"));
                number %= 1000000000;

                words.Append(ProcessGroup(number / 1000000, "Million"));
                number %= 1000000;

                words.Append(ProcessGroup(number / 1000, "Thousand"));
                number %= 1000;

                words.Append(ProcessGroup(number, ""));

                return words.ToString().Trim();
            }

            private static string ProcessGroup(int number, string scale)
            {
                if (number <= 0) return "";

                var groupWords = new StringBuilder();

                if (number >= 100)
                {
                    groupWords.Append(UnitsMap[number / 100] + " Hundred ");
                    number %= 100;
                }

                if (number > 0)
                {
                    if (number < 20)
                        groupWords.Append(UnitsMap[number]);
                    else
                    {
                        groupWords.Append(TensMap[number / 10]);
                        if ((number % 10) > 0)
                            groupWords.Append("-" + UnitsMap[number % 10]);
                    }
                }

                return groupWords.Append(" " + scale + " ").ToString();
            }
        }

    }
}