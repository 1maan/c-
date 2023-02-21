namespace aeomv
{
    internal class Program
    {

        static void IndexOfCapitals(string sen)
        {
            
            Console.Write("[");
            for (int i = 0; i < sen.Length; i++)
            {
                if (Char.IsUpper(sen[i]))
                {
                    Console.Write(i);
                    if (i != sen.Length - 1)
                    {
                        Console.Write(",");
                    }
                }
            }
            Console.Write("]");
        }

        static void Main(string[] args)
        {
            string sen = Console.ReadLine();
            IndexOfCapitals(sen);

        }
    }
}
