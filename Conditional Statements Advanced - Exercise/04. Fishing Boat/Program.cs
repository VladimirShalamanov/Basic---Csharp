using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceForSpring = 3000;
            const double priceForSummerAutumn = 4200;
            const double priceForWiner = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFisherman = int.Parse(Console.ReadLine());
            double totalMoney = 0;

            switch (season)
            {
                case "Winter":
                    totalMoney = priceForWiner;
                    break;
                case "Spring":
                    totalMoney = priceForSpring;
                    break;
                case "Summer":
                case "Autumn":
                    totalMoney = priceForSummerAutumn;
                    break;
            }

            if (numberFisherman <= 6)
            {
                totalMoney -= totalMoney * 0.10;
            }
            else if (numberFisherman >= 7 && numberFisherman <=11)
            {
                totalMoney -= totalMoney * 0.15;
            }
            else
            {
                totalMoney -= totalMoney * 0.25;
            }

            if (numberFisherman % 2 == 0 && season != "Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }

            if (budget >= totalMoney)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (totalMoney >= budget)
            {
                double needMoney = totalMoney - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:f2} leva.");
            }
        }
    }
}
