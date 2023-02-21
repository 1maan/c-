namespace aeomv
{
    internal class Program
    {

        

        static void Main(string[] args)
        {

           string tr = "none";
            Console.Write("Enter Your sentences: ");
            string sent = Console.ReadLine();
           for(int i =0; i< sent.Length; i++) {
                if(Convert.ToString(sent[i]) == " ")
                {
                    if(sent[i-1] == sent[i+1])
                    {
                         tr = "true";
                        Console.Write(" ");
                    }
                    if(sent[i - 1] != sent[i + 1])
                    {
                         tr = "false";
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write(sent[i]);
                }
           }
           if (tr == "false") { 
            Console.WriteLine(" -> false");
            }
           if (tr == "true")
            {
                Console.WriteLine(" -> true");
            }

        }
    }
}
