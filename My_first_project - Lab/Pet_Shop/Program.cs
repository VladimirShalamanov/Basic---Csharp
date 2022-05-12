using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double totalDogPrice = 2.50 * dogFood;
            double totalCatPrice = 4.00 * catFood;

            Console.WriteLine(totalDogPrice + totalCatPrice + " lv.");
        }
    }
}
