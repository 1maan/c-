using System;

namespace aeomv
{
    internal class Program
    {




        static void Main(string[] args)
        {

            Console.WriteLine("Enter How Many Items To add: ");
            int number = Convert.ToInt32(Console.ReadLine());


            String[] ar = new string[number];
            for(int i =0; i< number; i++)
            {
                Console.WriteLine("Enter Items: ");
                ar[i] = Console.ReadLine();
            }
            Console.Write("[");
            for (int j = 0; j < number; j++)
            {
                    Console.Write("\"");
                    Console.Write(ar[j]);
                    Console.Write("\"");
                if (j != ar.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");

        }
    }
}
