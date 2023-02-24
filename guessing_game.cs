using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int numberOfGuesses = 0;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I am thinking of a number between 1 and 100.");
        Console.WriteLine("Can you guess what it is?");

        while (true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            int guess;

            if (int.TryParse(input, out guess))
            {
                numberOfGuesses++;

                if (guess == numberToGuess)
                {
                    Console.WriteLine("Congratulations! You guessed the number in " + numberOfGuesses + " guesses.");
                    break;
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low. Guess again.");
                }
                else
                {
                    Console.WriteLine("Too high. Guess again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
