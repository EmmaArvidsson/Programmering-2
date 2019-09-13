using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Skriv in höjden på Rektangeln: ");
            double heightRectangle = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in bredden på Rektangeln: ");
            double widthRectangle = double.Parse(Console.ReadLine());

            Console.Write("Arean på Rektangeln är: ");
            double AreaRectangle = double.Parse(Console.ReadLine());

            Console.Write("Omkrets på Rektangeln är: ");
            double CircumferenceRectangle = double.Parse(Console.ReadLine());



                Console.WriteLine("Skriv in höjden på Triangeln: ");
                double heightTriangle  = double.Parse(Console.ReadLine());

                Console.WriteLine("Skriv in bredden på Triangeln: ");
                double widthTriangle = double.Parse(Console.ReadLine());

                Console.Write("Arean på Triangeln är: ");
                double AreaTriangle = double.Parse(Console.ReadLine());

                Console.Write("Omkretsen på Triangeln är: ");
                double CircumferenceTriangle = double.Parse(Console.ReadLine());
     

        }
    }
}
