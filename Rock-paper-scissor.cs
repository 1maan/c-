namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick one: Rock, Paper, Scissor");
            string pick = Console.ReadLine();
            string PC;
            Random rd = new Random();
           int number =  rd.Next(1, 4);
            if(number == 1)
            {
                 PC = "rock";
            }else if(number == 2)
            {
                 PC = "paper";
            }
            else
            {
                 PC = "scissor";
            }
            if (pick.ToLower() == "paper" || pick.ToLower() == "rock" || pick.ToLower() == "scissor")
            {
                if (pick.ToLower() == PC)
                {
                    Console.WriteLine();
                    Console.WriteLine("PC Pick:" + PC);
                    Console.WriteLine("YOu Pick:" + pick);
                    Console.WriteLine("Tie");
                }
                else if (pick != PC)
                {
                    Console.WriteLine();
                    Console.WriteLine("PC Pick:" + PC); Console.WriteLine("YOu Pick:" + pick);
                    Console.WriteLine("You Win");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("PC Pick:" + PC); Console.WriteLine("YOu Pick:" + pick);
                    Console.WriteLine("You Lose");
                }

            }
            else
            {
                Console.WriteLine("Inglich?");
            }

        }
    }
}
