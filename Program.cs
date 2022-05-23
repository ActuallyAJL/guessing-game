using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to secret number. shhhhh...");
            Console.WriteLine("Choose a difficulty. Type: ");
            Console.WriteLine("E-easy (8 guesses)  M-medium (6 guesses)  H-hard (4 guesses)");
            bool userIsFilthyCheater = false;
            string diff = Console.ReadLine().ToLower();
            int guessesRemaining = 0;
            if (diff == "e")
            {
                guessesRemaining = 8;
            }
            else if (diff == "m")
            {
                guessesRemaining = 6;
            }
            else if (diff == "h")
            {
                guessesRemaining = 4;
            }
            else if (diff == "c")
            {
                guessesRemaining = 100;
                userIsFilthyCheater = true;
            }
            else
            {
                Console.WriteLine("huh?");
                guessesRemaining = 0;
            }

            Random r = new Random();
            int secretNumber = r.Next(1, 101);

            while (guessesRemaining > 0)
            {
                if (userIsFilthyCheater)
                {
                    guessesRemaining = 100;
                }

                Console.WriteLine($"Will you guess the secret number between 1-100? You have {guessesRemaining} guesses remaining.");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Why yes, how did you know?!");
                    guessesRemaining = 0;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Get your mind out of the gutter, hint hint");
                    guessesRemaining--;
                }
                else
                {
                    Console.WriteLine("Get your head out of the clouds, he said with a sly face.");
                    guessesRemaining--;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
