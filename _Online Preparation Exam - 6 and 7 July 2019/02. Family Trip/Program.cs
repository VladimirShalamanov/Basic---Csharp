using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetAvalible = double.Parse(Console.ReadLine());
            int nughtNum = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            int percentCosts = int.Parse(Console.ReadLine());

            if (nughtNum > 7)
            {
                priceNight -= priceNight * 0.05;
            }

            double priceAllNight = nughtNum * priceNight;
            double costs = budgetAvalible * ((double)percentCosts / 100);
            double sum = priceAllNight + costs;

            if (sum <= budgetAvalible)
            {
                double afterHoliday = budgetAvalible - sum;
                Console.WriteLine($"Ivanovi will be left with {afterHoliday:f2} leva after vacation.");
            }
            else if (sum > budgetAvalible)
            {
                double neededMoney = sum - budgetAvalible;
                Console.WriteLine($"{neededMoney:f2} leva needed.");
            }
        }
    }
}
