using System;
using System.Collections.Generic;

//Develop a program for a newspaper vendor to determine which newspapers he should collect most copies
//to maximize his sales for the week based on the previous weeks performance assuming demands and customers preference remains the same.
//PMNews                Guardian                  Punch                     The Sun
//Quantity    Price     Quantity    Price         Quantity    Price         Quantity    Price
//23          150       10          324.56        12          245.35        7           420
//20          160       32          300           20          220           10          400
//18          155       27          315.28        35          265.5         13          450.24
//14          175       21          340           19          290.14        8           400
// Collect newspapers and names. // final result return newspaper name, and predicted income. average across the 4 weeks.

namespace WeeklyChallenge
{
    internal class Program
    {
        private static int _paperCount;
        private static readonly List<string> Newspapers = new List<string>();

        private static void Main(string[] args)
        {
            //GreetVendor();
            GetNewspaperDetails();
            //GetWeekDetails();
        }

        public static void GreetVendor()
        {
            Console.Write("Good day, what's your name? ");
            var vendorName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(vendorName))
            {
                Console.WriteLine(
                    "Hello there! This program is to determine which newspapers you should collect to maximize your \nsales for the week based on previous weeks performance.");
            }
            else
            {
                Console.WriteLine(
                    "Hello {0}! This program is to determine which newspapers you should collect to maximize your \nsales for the week based on previous weeks performance.",
                    vendorName);
            }
        }

        public static void GetNewspaperDetails()
        {
            Console.Write("How many types of newspapers do you sell? ");
            var validCount = int.TryParse(Console.ReadLine(), out _paperCount);

            while (!validCount)
            {
                Console.Write("Please enter a valid number ");
                validCount = int.TryParse(Console.ReadLine(), out _paperCount);
            }

            var newspapers = new List<Newspaper>(_paperCount);

            Console.Write(
                "What are their names? Just type it in then press enter. I'll know when you've given me all of them.\n");

            for (var i = 1; i <= _paperCount; i++)
            {
                Console.Write("{0}. ", i);
                var name = Console.ReadLine();
                Newspapers.Add(name);
                newspapers.Add(new Newspaper(name));
            }

            Console.WriteLine(newspapers[0].Name);
        }

        public static void GetWeekDetails()
        {
            Console.WriteLine("How many weeks have you sold the papers so far? ");
            var validWeekCount = int.TryParse(Console.ReadLine(), out var weeksSold);

            while (!validWeekCount)
            {
                Console.Write("Please enter a valid number to get your answer");
                validWeekCount = int.TryParse(Console.ReadLine(), out weeksSold);
            }

            var quantityList = new List<int>(weeksSold);
            for (var i = 1; i <= weeksSold; i++)
            {
                foreach (var item in Newspapers)
                {
                    Console.Write("Enter the quantity of {0} sold for week {1}: ", item, i);
                    var quantity = int.Parse(Console.ReadLine());
                    quantityList.Add(quantity);
                }

                for (int j = 0; j < Newspapers.Count; j++)
                {
                    Console.WriteLine("Enter the quantity of {0} sold for week {1}: ", Newspapers[j], i);
                }
            }
        }

        public class Newspaper
        {
            public string Name { get; set; }
            public int[] Quantity { get; set; }
            public int[] Price { get; set; }

            public Newspaper(string name)
            {
                Name = name;
            }
        }
    }
}