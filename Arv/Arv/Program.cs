using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape shape = new Triangle(1,1);

            Console.WriteLine("Skriv figuren: ");
            string s = Console.ReadLine();

            if (s == "triangel")
            {
                Console.WriteLine("Skriv in höjden: ");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Skriv in bredden: ");
                int width = int.Parse(Console.ReadLine());
                shape = new Triangle(height, width);
            }

            else if (s == "rektangel") 
            {
                Console.WriteLine("Skriv in höjden: ");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Skriv in bredden: ");
                int width = int.Parse(Console.ReadLine());
                shape = new Rectangle(height, width);

            }

            else
            {
                Console.WriteLine("Skriv in radien: ");
                int radius = int.Parse(Console.ReadLine());
                shape = new Circle(radius);

            }

            Console.WriteLine("Arean är: "+ shape.Area());

            Console.WriteLine("Omkretsen är: "+ shape.Circumference());
        }
    }
}
