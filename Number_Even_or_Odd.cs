namespace aeomv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<number+1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " odd");
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " even");
                }
            }
        }
    }
}
