using System;

namespace _02._Bracelet_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForDay = double.Parse(Console.ReadLine());
            double moneyWinFromSell = double.Parse(Console.ReadLine());
            double costsAllPeriod = double.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double saveMoney = 5 * moneyForDay;
            double winMoney = 5 * moneyWinFromSell;
            double totalSaveMoney = saveMoney + winMoney;
            double costs = totalSaveMoney - costsAllPeriod;

            if (costs > priceGift)
            {
                Console.WriteLine($"Profit: {costs:f2} BGN, the gift has been purchased.");
            }
            else if (costs < priceGift)
            {
                double neededMoney = priceGift - costs;
                Console.WriteLine($"Insufficient money: {neededMoney:f2} BGN.");
            }
        }
    }
}
