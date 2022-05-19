using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyardMeters = int.Parse(Console.ReadLine());
            double grapesOneMeter = double.Parse(Console.ReadLine());
            int wineNeededLiters = int.Parse(Console.ReadLine());
            int workersNumber = int.Parse(Console.ReadLine());
            const double MAKE_ONE_LITER_WINE = 2.5;

            double totalGrapes = vineyardMeters * grapesOneMeter;
            double wineFromVineyard = 0.40 * totalGrapes / MAKE_ONE_LITER_WINE;
            double wineNotEnough = wineNeededLiters - wineFromVineyard;
            if (wineFromVineyard < wineNeededLiters)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNotEnough)} liters wine needed.");
            }
            else if (wineFromVineyard >= wineNeededLiters)
            {
                double wineLeft = wineFromVineyard - wineNeededLiters;
                double wineLeftFromOnePerson = wineLeft / workersNumber;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineFromVineyard)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeftFromOnePerson)} liters per person.");
            }
        }
    }
}
