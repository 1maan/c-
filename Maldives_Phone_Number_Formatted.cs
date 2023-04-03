namespace hang_mannn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Phone Number:");
            string numberst = Console.ReadLine();
            if (numberst[0] == '9' && numberst[1] == '6' && numberst[2] == '0')
            {

                if (numberst[3] == '9' || numberst[3] == '7')
                {
                    if(numberst.Length == 10)
                    {
                        Console.WriteLine(numberst);
                    }
                    else
                    {
                        Console.WriteLine("Length Wrong");
                    }
                }
                else
                {

                }
            }
                else if (numberst[0] == '9' || numberst[0] == '7')
                {
                    if (numberst.Length == 7)
                    {
                        Console.WriteLine(numberst);

                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                }
            else
            {
                Console.WriteLine("Wrong");

            }


        }
    }
}
//aeomv.com
