using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int litersFuel = int.Parse(Console.ReadLine());
            const int mininum = 25;

            if (fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas")
            {
                if (litersFuel >= mininum)
                {
                    Console.WriteLine($"You have enough {fuel.ToLower()}.");
                }
                else if (litersFuel < mininum)
                {
                    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                }
            }

            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
