using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double totalPerimeter = Math.PI * r * 2;
            double totalArea = Math.PI * r * r;

            Console.WriteLine($"{totalArea:f2}");
            Console.WriteLine($"{totalPerimeter:f2}");
        }
    }
}
