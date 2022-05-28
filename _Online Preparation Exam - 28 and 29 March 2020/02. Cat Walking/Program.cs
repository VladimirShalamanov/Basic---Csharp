using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minWalkDay = int.Parse(Console.ReadLine());
            int numWalks = int.Parse(Console.ReadLine());
            int consumeCaloriesDay = int.Parse(Console.ReadLine());

            double totalMin = minWalkDay * numWalks;
            double caloriesBurned = totalMin * 5;

            double caloriesDay = consumeCaloriesDay - (consumeCaloriesDay * 0.5);

            if (caloriesBurned >= caloriesDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
