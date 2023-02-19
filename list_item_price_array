using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter How many Items:");
            int itemsct = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            var items = new List<string>();
            var price = new List<string>();
            while (i < (itemsct + 1))
            {
                Console.WriteLine();
                Console.Write("Enter Items Name "+i+": ");
                string sel = Console.ReadLine();
                items.Add(sel);
                Console.Write("Enter Items Price " + i + ": ");
                string pri = Console.ReadLine();
                price.Add(pri);
                i++;
                
            }
            Console.WriteLine();

            Console.WriteLine("Items in the list:");
            int j = 0;
            while(j < itemsct)
                {
                     foreach(string item in items) {
                     Console.WriteLine(j+": " + item);
                     j++;
                }
            }
            int e = 0;
            Console.WriteLine("To Quit Type \"00\"");
            while (e< itemsct)
            {
                Console.WriteLine();
                Console.Write("Check Item Price: ");
                int itempricecheck = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(items[itempricecheck] +" Price is "+ price[itempricecheck]);
                e++;
                
            }






        }
    }
}
