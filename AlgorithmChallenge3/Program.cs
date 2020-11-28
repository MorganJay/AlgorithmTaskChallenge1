using System;

//Write a C# Sharp program to check if a given word starts with 'Sa' and
//count the numbers of characters in the word that do not include character ‘e’ or ‘m’

namespace AlgorithmChallenge3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string word;
            var count = 0;
            do
            {
                Console.WriteLine("Please type in a word");
                word = Console.ReadLine()?.ToLower();     // word = Console.ReadLine()?.ToLower();- complicated

                if (string.IsNullOrWhiteSpace(word)) continue; // if the user input is null or consists of space characters, skip all other conditions
                if (word.StartsWith("sa"))
                {
                    Console.WriteLine("That word starts with Sa");
                }
                else if (word.Length == 1 || word.Length == 2)
                {
                    Console.WriteLine("Was that a word?");
                    Console.WriteLine("Well, it doesn't start with Sa either");
                }
                else
                {
                    Console.WriteLine("Hmm, that word doesn't start with Sa");
                }

                //count += word.Count(t => !t.ToString().Equals("e") && !t.ToString().Equals("m")); - complicated a bit, resembles JS array method(filter)
                foreach (var t in word)
                {
                    if (!t.ToString().Equals("e") && !t.ToString().Equals("m"))
                    {
                        count++; // increase the count if the character are neither e nor m.
                    }
                }
                Console.WriteLine("There are {0} characters that do not include \"e\" and \"m\" in the word {1}.", count, word);
            } while (string.IsNullOrWhiteSpace(word));

            Console.ReadLine();
        }
    }
}