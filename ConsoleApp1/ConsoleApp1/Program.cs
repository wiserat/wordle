using System;
using System.IO;

namespace ConsoleApp1
{
    
    public class CharWithColor
    {
        public char Character { get; set; }
        public ConsoleColor Color { get; set; }

        public CharWithColor(char character, ConsoleColor color)
        {
            Character = character;
            Color = color;
        }
    }
    
    class Program
    {

        static bool End()
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("End game? [y/n]: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                Environment.Exit(0);
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            string[] lines =
                File.ReadAllLines("../../../words.txt");
            Random random = new Random();
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("Wordle! Try to guess the word, type a 5-char word".ToUpper());
                Console.ResetColor();
                Console.WriteLine();
                
                int randomIndex = random.Next(lines.Length);
                string word = lines[randomIndex];
                List<CharWithColor[]> words = new List<CharWithColor[]>();

                int numberOfTries = 6;
                while (true)
                {
                    Console.Write("How hard do you want the game to be? (amount of guesses): ");
                    string numberOfTriesString = Console.ReadLine();
                    if (int.TryParse(numberOfTriesString, out int numberOfTriesInt) && numberOfTriesInt > 0)
                    {
                        numberOfTries = numberOfTriesInt;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Different input expected!");
                        Console.ResetColor();
                    }

                }
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Okay, {numberOfTries} it is. Enjoy the game!");
                Console.ResetColor();
                
                bool won = false;

                for (int i = 0; i < numberOfTries; i++)
                {
                    string guess = "";
                    bool firstTimeGuessing = true;
                    Console.WriteLine();
                    while (guess.Length != 5 || !lines.Contains(guess))
                    {
                        if (!firstTimeGuessing)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Different input expected!");
                            Console.ResetColor();
                        }
                        firstTimeGuessing = false;
                        Console.ResetColor();
                        Console.Write($"Guess {i + 1}: ");
                        guess = Console.ReadLine();
                        if (guess == word)
                        {
                            Console.Write("Correctly guessed: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(guess.ToUpper());
                            won = End();
                        }
                    }

                    if (won)
                    {
                        break;
                    }

                    foreach (CharWithColor[] displayWord in words)
                    {
                        foreach (var ch in displayWord)
                        {
                            Console.ForegroundColor = ch.Color;
                            Console.Write(ch.Character);
                        }
                        Console.WriteLine();
                    }
                    CharWithColor[] guessedWord = new CharWithColor[5];
                    for (int j = 0; j < guess.Length; j++)
                    {
                        if (guess[j] == word[j])
                        {
                            guessedWord[j] = new CharWithColor(guess[j], ConsoleColor.Green);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(guess[j]);
                        }
                        else if (word.Contains(guess[j]))
                        {
                            guessedWord[j] = new CharWithColor(guess[j], ConsoleColor.Yellow);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(guess[j]);
                        }
                        else
                        {
                            guessedWord[j] = new CharWithColor(guess[j], ConsoleColor.White);
                            Console.ResetColor();
                            Console.Write(guess[j]);
                        }
                    }
                    words.Add(guessedWord);

                    Console.WriteLine();
                }
                if (won)
                {
                    continue;
                }
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"You loosed! Correct word: {word}");
                End();
            }
        }
    }
}