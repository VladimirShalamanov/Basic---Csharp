using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoplesNum = int.Parse(Console.ReadLine());
            double feeEntrance = double.Parse(Console.ReadLine());
            double priceDeckChair = double.Parse(Console.ReadLine());
            double priceUmbrella = double.Parse(Console.ReadLine());

            double totalEntrace = peoplesNum * feeEntrance;
            double percentegeDeckChair = Math.Ceiling(peoplesNum * 0.75);
            double totalDeckChair = percentegeDeckChair * priceDeckChair;
            double percentegeUmbrella = Math.Ceiling(peoplesNum * 0.5);
            double totalUmbrella = percentegeUmbrella * priceUmbrella;

            double sum = totalEntrace + totalDeckChair + totalUmbrella;

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
