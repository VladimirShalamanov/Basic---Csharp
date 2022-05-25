using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = Console.ReadLine();

            while (location != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < budget)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {location}!");

                location = Console.ReadLine();
            }
        }
    }
}
