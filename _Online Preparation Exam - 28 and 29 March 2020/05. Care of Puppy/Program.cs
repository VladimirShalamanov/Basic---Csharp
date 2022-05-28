using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodDogKg = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int totalFood = 0;

            while (command != "Adopted")
            {
                int currentFood = int.Parse(command);
                totalFood += currentFood;

                command = Console.ReadLine();
            }

            int dogFoodGr = foodDogKg * 1000;

            if (totalFood <= dogFoodGr)
            {
                int leftFood = dogFoodGr - totalFood;
                Console.WriteLine($"Food is enough! Leftovers: {leftFood} grams.");
            }
            else if (dogFoodGr <= totalFood)
            {
                int neededFood = Math.Abs(dogFoodGr - totalFood);
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
        }
    }
}
