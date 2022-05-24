using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string POSIBLE_PLACES = "";
            string LOCATION = "";

            if (budget <= 1000)
            {
                POSIBLE_PLACES = "Camp";
                if (season == "Summer")
                {
                    LOCATION = "Alaska";
                    budget *= 0.65;
                }
                else if (season == "Winter")
                {
                    LOCATION = "Morocco";
                    budget *= 0.45;
                }
            }

            else if (1000 < budget && budget <= 3000)
            {
                POSIBLE_PLACES = "Hut";
                if (season == "Summer")
                {
                    LOCATION = "Alaska";
                    budget *= 0.80;
                }
                else if (season == "Winter")
                {
                    LOCATION = "Morocco";
                    budget *= 0.60;
                }
            }

            else if (3000 < budget)
            {
                POSIBLE_PLACES = "Hotel";
                budget *= 0.90;
                if (season == "Summer")
                {
                    LOCATION = "Alaska";
                }
                else if (season == "Winter")
                {
                    LOCATION = "Morocco";
                }
            }

            Console.WriteLine($"{LOCATION} - {POSIBLE_PLACES} - {budget:f2}");
        }
    }
}
