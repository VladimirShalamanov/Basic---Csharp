using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNum = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double totalDogEat = 0;
            double totalCatEat = 0;
            double biscuitsEat = 0;

            for (int i = 1; i <= daysNum; i++)
            {
                double dogEatFood = double.Parse(Console.ReadLine());
                double catEatFood = double.Parse(Console.ReadLine());

                totalDogEat += dogEatFood;
                totalCatEat += catEatFood;

                if (i % 3 == 0)
                {
                    double currentBiscuitsEat = (dogEatFood + catEatFood) * 0.1;
                    biscuitsEat += currentBiscuitsEat;
                }
            }

            double totalEatFood = totalDogEat + totalCatEat;

            double percentegeFood = (totalEatFood / totalFood) * 100;
            double percentegeDog = (totalDogEat / totalEatFood) * 100;
            double percentegeCat = (totalCatEat / totalEatFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuitsEat)}gr.");
            Console.WriteLine($"{percentegeFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentegeDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentegeCat:f2}% eaten from the cat.");
        }
    }
}
