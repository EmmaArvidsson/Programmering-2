using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape shape = new Triangle(1,1);
            Console.WriteLine("Skriv in höjden: ");
            int height = int.Parse(Console.ReadLine());                                             

            Console.WriteLine("Skriv in bredden: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv figuren: ");
            string s = Console.ReadLine();

            if (s == "triangel")
            {
                shape = new Triangle(height, width);
            }

            else 
            {
                shape = new Rectangle(height, width);

            }

            Console.WriteLine("Arean är: "+ shape.Area());

            Console.WriteLine("Omkretsen är: "+ shape.Circumference());
        }
    }
}
