using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numBeer = int.Parse(Console.ReadLine());
            int numPacks = int.Parse(Console.ReadLine());

            double totalPriceBeer = 1.20 * numBeer;
            double priceOnePack = totalPriceBeer * 0.45;
            double totalPricePack = Math.Ceiling(priceOnePack * numPacks);
            double totalSum = totalPriceBeer + totalPricePack;

            if (totalSum <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalSum:f2} leva left.");
            }
            else if (totalSum >= budget)
            {
                Console.WriteLine($"{name} needs {totalSum - budget:f2} more leva!");
            }
        }
    }
}
