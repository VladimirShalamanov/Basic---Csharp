using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberDays = double.Parse(Console.ReadLine());
            double foodKg = double.Parse(Console.ReadLine());
            double dogFoodKgForDay = double.Parse(Console.ReadLine());
            double catFoodKgForDay = double.Parse(Console.ReadLine());
            double turtleFoodGramsForDay = double.Parse(Console.ReadLine());

            double dogNeededFood = numberDays * dogFoodKgForDay;
            double catNeededFood = numberDays * catFoodKgForDay;
            double turtleNeededFood = numberDays * (turtleFoodGramsForDay / 1000);
            double totalFood = dogNeededFood + catNeededFood + turtleNeededFood;

            if (totalFood <= foodKg)
            {
                double foodLeft = (foodKg - totalFood);
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodNeeded = Math.Ceiling(totalFood - foodKg);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
