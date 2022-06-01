using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLocation = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numLocation; i++)
            {
                double totalGold = 0;
                double averageGoldForDay = double.Parse(Console.ReadLine());
                int workDay = int.Parse(Console.ReadLine());

                for (int j = 1; j <= workDay; j++)
                {
                    double kgGold = double.Parse(Console.ReadLine());
                    totalGold += kgGold;
                }
                totalGold /= workDay;

                if (totalGold >= averageGoldForDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {totalGold:f2}.");
                }
                else if (totalGold < averageGoldForDay)
                {
                    Console.WriteLine($"You need {averageGoldForDay - totalGold:f2} gold.");
                }
            }
        }
    }
}
