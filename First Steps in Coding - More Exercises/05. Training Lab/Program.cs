using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double deskRows = Math.Floor(((h * 100) - 100) / 70);
            double number = Math.Floor((w * 100) / 120);

            double numberOfPlaces = deskRows * number - 3;

            Console.WriteLine(numberOfPlaces);
        }
    }
}
