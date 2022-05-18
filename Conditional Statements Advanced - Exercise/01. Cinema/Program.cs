using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double premiere = 12;
            const double normal = 7.50;
            const double discount = 5;

            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (typeProjection == "Premiere")
            {
                income = rows * columns * premiere;
            }
            else if (typeProjection == "Normal")
            {
                income = rows * columns * normal;
            }
            else if (typeProjection == "Discount")
            {
                income = rows * columns * discount;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
