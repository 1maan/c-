namespace aeomv
{
    internal class Program
    {
        static void Reverse(string sen)
        {
            for (int i = 0; i < sen.Length; i++)
            {
                if (char.IsUpper(sen[i]))
                {
                    Console.Write(char.ToLower(sen[i]));
                }
                if (char.IsLower(sen[i]))
                {
                    Console.Write(char.ToUpper(sen[i]));
                }
                if (Convert.ToString(sen[i]) == " ")
                {
                    Console.Write(" ");
                }

            }
        }

        static void uppercase(string sen)
        {
            for (int i = 0; i < sen.Length; i++)
            {
                if (char.IsUpper(sen[i]))
                {
                    Console.Write(char.ToLower(sen[i]));
                }
                if (char.IsLower(sen[i]))
                {
                    Console.Write(char.ToLower(sen[i]));
                }
                if (Convert.ToString(sen[i]) == " ")
                {
                    Console.Write(" ");
                }

            }
        }


        static void lowercase(string sen)
        {
            for (int i = 0; i < sen.Length; i++)
            {
                if (char.IsUpper(sen[i]))
                {
                    Console.Write(char.ToUpper(sen[i]));
                }
                if (char.IsLower(sen[i]))
                {
                    Console.Write(char.ToUpper(sen[i]));
                }
                if (Convert.ToString(sen[i]) == " ")
                {
                    Console.Write(" ");
                }

            }
        }

        static void Main(string[] args)
        {
            //Reverse the Case
            Console.WriteLine("1: Reverse the Case");
            Console.WriteLine("2: upper-case To lower-case");
            Console.WriteLine("3: lower-case To upper-case");

            Console.Write("Enter Number Between 1-3: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Text: ");
            string sen = Console.ReadLine();
            if (Number == 1)
            {
            Reverse(sen);
            }
            if (Number == 2)
            {
                uppercase(sen);

            }
            if (Number == 3)
            {
                lowercase(sen);
            }




        }
    }
}
