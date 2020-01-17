using System;

namespace felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;
            if (!TryParse(Console.ReadLine(), out resultat))
                Console.WriteLine("Skriv in en siffra");

        }
        public static bool TryParse(string s, out int result)
        {

        try
            {
               
                result = int.Parse(s);
                return true;
            }

        catch
            {
                result = 0;
                return false;
            }


        }
    }
}
