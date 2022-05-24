using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmMonth = double.Parse(Console.ReadLine());

            double salary = 0;

            if (10000 < kmMonth && kmMonth <= 20000)
            {
                salary = ((kmMonth * 1.45) * 4) * 0.9;
            }

            else if (season == "Spring" || season == "Autumn")
            {
                if (kmMonth <= 5000)
                {
                    salary = ((kmMonth * 0.75) * 4) * 0.9;
                }
                else if (5000 < kmMonth && kmMonth <= 10000)
                {
                    salary = ((kmMonth * 0.95) * 4) * 0.9;
                }
            }

            else if (season == "Summer")
            {
                if (kmMonth <= 5000)
                {
                    salary = ((kmMonth * 0.90) * 4) * 0.9;
                }
                else if (5000 < kmMonth && kmMonth <= 10000)
                {
                    salary = ((kmMonth * 1.10) * 4) * 0.9;
                }
            }

            else if (season == "Winter")
            {
                if (kmMonth <= 5000)
                {
                    salary = ((kmMonth * 1.05) * 4) * 0.9;
                }
                else if (5000 < kmMonth && kmMonth <= 10000)
                {
                    salary = ((kmMonth * 1.25) * 4) * 0.9;
                }
            }

            Console.WriteLine($"{salary:f2}");
        }
    }
}
