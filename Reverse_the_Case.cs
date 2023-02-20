namespace aeomv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse the Case
            string sen = "Happy Birthday";
            for(int i = 0; i < sen.Length; i++)
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
    }
}
