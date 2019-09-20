using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape shape = new Triangle(1,1);
            Console.WriteLine("Skriv in höjden på Rektangeln: ");
            int heightRectangle = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in bredden på Rektangeln: ");
            int widthRectangle = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            if (s == "triangel")
            {
                shape = new Triangle(heightRectangle, widthRectangle);
            }

            else 
            {
                shape = new Rectangle(heightRectangle, widthRectangle);

            }
        }
    }
}
