namespace aeomv
{
    internal class Program
    {

        static void ReverseAndNot(string Number)
        {
            int re = Number.Length;
            for (int j = re - 1; j > -1; j--)
            {
                Console.Write(Number[j]);
            }
            for (int i = 0; i < re; i++)
            {
                Console.Write(Number[i]);
            }
        }

        static void Main(string[] args)
        {
            string Number = Console.ReadLine();
            ReverseAndNot(Number);

           

        }
    }
}
