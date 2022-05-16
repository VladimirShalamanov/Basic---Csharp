using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double dollPrice = 3;
            const double bearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckprice = 2;

            double excursionPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzels = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            int toysCount = numberOfPuzzels + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

            double totalPrice = numberOfPuzzels * puzzlePrice + numberOfDolls * dollPrice + numberOfBears * bearPrice + numberOfMinions * minionPrice + numberOfTrucks * truckprice;

            if (toysCount >= 50)
            {
                totalPrice *= 0.75;
            }

            double rent = totalPrice * 0.10;
            double difference = Math.Abs(rent + excursionPrice - totalPrice);
            if (totalPrice >= rent + excursionPrice)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }

        }
    }
}
