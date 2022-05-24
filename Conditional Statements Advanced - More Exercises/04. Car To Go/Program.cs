using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string CLASS = "";
            string TYPE_CAR = "";

            if (budget <= 100)
            {
                CLASS = "Economy class";
                if (season == "Summer")
                {
                    TYPE_CAR = "Cabrio";
                    budget *= 0.35;
                }
                else if (season == "Winter")
                {
                    TYPE_CAR = "Jeep";
                    budget *= 0.65;
                }
            }
            else if (100 < budget && budget <= 500)
            {
                CLASS = "Compact class";
                if (season == "Summer")
                {
                    TYPE_CAR = "Cabrio";
                    budget *= 0.45;
                }
                else if (season == "Winter")
                {
                    TYPE_CAR = "Jeep";
                    budget *= 0.80;
                }
            }
            else if (500 < budget)
            {
                CLASS = "Luxury class";
                if (season == "Summer" || season == "Winter")
                {
                    TYPE_CAR = "Jeep";
                    budget *= 0.90;
                }
            }

            Console.WriteLine(CLASS);
            Console.WriteLine($"{TYPE_CAR} - {budget:f2}");
        }
    }
}
