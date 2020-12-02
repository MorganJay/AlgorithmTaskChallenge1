using System;

//Write a C# program to compute the sum of all positive prime numbers
//that can be in the C# int data type

namespace AlgorithmChallenge2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ulong sum = 0;
            Console.WriteLine("This program is to compute the sum of all positive prime numbers that are in the C# int data type, \nthat is from 0 - {0:###,###}.",
                int.MaxValue);
            Console.WriteLine("\nPlease wait while I'm calculating. \nThis might take a while....");
            for (var i = 0; i < int.MaxValue; i++)
            {
                for (var j = i - 1; j > 0; j--)
                {
                    if (j == 1)
                    {
                        sum += (ulong)i;
                    }
                    if (i % j == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("\n\nPhew! After much work from our robots, the sum of all the prime numbers therein is {0:###,###}.", sum);
        }
    }
}