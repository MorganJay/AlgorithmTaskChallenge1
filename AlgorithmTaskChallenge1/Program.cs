//Write a C# Sharp program to check two given integers and return true if one of them is 30 or if their sum is 30
using System;

namespace AlgorithmTaskChallenge1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            bool valid;
            Console.WriteLine("This is a program to check two given integers and return true if one of them is 30 or their sum is equal 30");
            do
            {
                Console.Write("\nEnter the first number ");
                valid = int.TryParse(Console.ReadLine(), out firstNumber); // return true and stores the number in the variable if the parse method succeeds
            } while (!valid);
            // these loops are to ensure the user types in an integer
            do
            {
                Console.Write("\nEnter the second number ");
                valid = int.TryParse(Console.ReadLine(), out secondNumber);
            } while (!valid);

            var sum = firstNumber + secondNumber;
            if (firstNumber == 30 || secondNumber == 30)
            {
                Console.WriteLine("True!");
            }
            else if (sum == 30)
            {
                Console.WriteLine("True! don't disguise");
            }
            else
            {
                Console.WriteLine("\nThe numbers you entered are {0} and {1} and...", firstNumber, secondNumber);
                Console.WriteLine("\nTheir sum is {0}.", sum);
            }
            Console.WriteLine("\n\nThe end.");
            Console.ReadLine();
        }
    }
}