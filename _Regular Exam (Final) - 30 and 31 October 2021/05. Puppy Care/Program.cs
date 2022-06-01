using System;

namespace _05._Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgFood = int.Parse(Console.ReadLine());
            int kgToGr = kgFood * 1000;
            string command = Console.ReadLine();
            int totalFood = 0;

            while (command != "Adopted")
            {
                int grFood = int.Parse(command);
                totalFood += grFood;
                
                command = Console.ReadLine();
            }

            if (kgToGr >= totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {kgToGr-totalFood} grams.");
            }
            else if (totalFood > kgToGr)
            {
                Console.WriteLine($"Food is not enough. You need {totalFood-kgToGr} grams more.");
            }
        }
    }
}
