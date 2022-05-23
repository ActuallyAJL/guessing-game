using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int secretNumber = r.Next(100);
            int guessesRemaining = 4;

            while (guessesRemaining > 0)
            {

                Console.WriteLine($"Will you guess the secret number? You have {guessesRemaining} guesses remaining.");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Why yes, how did you know?!");
                    guessesRemaining = 0;
                }
                else
                {
                    Console.WriteLine("Noooooooo :')");
                    guessesRemaining--;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
