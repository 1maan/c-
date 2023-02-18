using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp8;
class Program
{

    static void RandomNumber(out int numberRn)
    {
        Random rnd = new Random();
        numberRn = rnd.Next(1, 100);
    }




    static void Main(string[] args)
    {
        int numberRn;
        int guessnumber = 0;
        RandomNumber(out numberRn);
        Console.WriteLine("Welcome to the Guess the Number game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");
        while (guessnumber != numberRn)
        { 
            Console.WriteLine();
        Console.Write("Enter your guess: ");
        guessnumber = Convert.ToInt32(Console.ReadLine());
        if (guessnumber < numberRn)
        {
            Console.WriteLine("Too low.");
        }
        if (guessnumber == numberRn)
        {
        Console.WriteLine();
        Console.WriteLine("Congratulations! You guessed the number.");
        }
        if (guessnumber > numberRn)
        {
        Console.WriteLine("Too high.");
        }
        }
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
