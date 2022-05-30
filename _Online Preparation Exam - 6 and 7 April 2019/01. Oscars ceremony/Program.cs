using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentHall = double.Parse(Console.ReadLine());

            double figurines = rentHall - (rentHall * 0.3);
            double catering = figurines - (figurines * 0.15);
            double soundSistem = catering / 2;

            double totalPrice = rentHall + figurines + catering + soundSistem;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
