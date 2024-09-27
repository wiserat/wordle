using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "array";
            Console.WriteLine("Wordle! 6 tries to guess the word, type a 5char word");

            for (int i = 0; i <= 6; i++)
            {
                string guess = "";
                while (guess.Length != 5)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.Write("Guess: ");
                    guess = Console.ReadLine();
                    if (guess == word)
                    {
                        Console.Write("Correctly guessed: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(guess.ToUpper());
                        Environment.Exit(0);
                    }
                }

                for (int j = 0; j < guess.Length; j++)
                {
                    if (guess[j] == word[j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(guess[j]);
                    }
                    else if (word.Contains(guess[j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(guess[j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(guess[j]);
                    }
                }
            }
        }
    }
}