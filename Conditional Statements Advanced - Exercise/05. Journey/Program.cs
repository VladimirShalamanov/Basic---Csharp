using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string holiday = "";
            double totalMoney = 0;

            if (budget <= 100)
            {
                location = "Bulgaria";

                if (season == "summer")
                {
                    holiday = "Camp";
                    totalMoney = budget * 0.30;
                }
                else if (season == "winter")
                {
                    holiday = "Hotel";
                    totalMoney = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    holiday = "Camp";
                    totalMoney = budget * 0.40;
                }
                else if (season == "winter")
                {
                    holiday = "Hotel";
                    totalMoney = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                location = "Europe";
                holiday = "Hotel";
                totalMoney = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{holiday} - {totalMoney:f2}");
        }
    }
}
