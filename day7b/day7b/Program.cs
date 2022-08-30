using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string theWord = "The Bird";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            string guess = "";

            Console.WriteLine("Guesses: " + guessCount);
            Console.Write("Enter Guess: ");
            guess = Console.ReadLine();
            guessCount++;

            while (guess != theWord)
            {
                Console.WriteLine("Try again.");
                Console.ReadLine();
                Console.WriteLine("Guesses: " + guessCount);
                Console.Write("Enter Guess: ");
                guess = Console.ReadLine();
                guessCount++;
                if (guessLimit < guessCount)
                {
                    outOfGuesses = true;
                }
                if (outOfGuesses == true)
                {
                    break;

                }
            }
            if (outOfGuesses == false)
            {
                Console.WriteLine("You win");

            }
            else
            {
                Console.WriteLine("You lose");
            }
            Console.ReadKey();
        }
    }
}