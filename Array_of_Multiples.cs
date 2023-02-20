namespace aeomv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array of Multiples
            Console.Write("Enter Mult Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Length: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            int nb = 1;
            Console.Write("[");
            for (nb=1; nb <= Length-1; nb++) {
                Console.Write((nb*number)+",");
            }
            Console.Write((nb*number));
            Console.Write("]");
        }
    }
}
