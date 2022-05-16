using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            const double videocardPrice = 250;

            double budget = double.Parse(Console.ReadLine());
            int numberVideocard = int.Parse(Console.ReadLine());
            int numberCpu = int.Parse(Console.ReadLine());
            int numberRamMemory = int.Parse(Console.ReadLine());

            double totalVideocardPrice = numberVideocard * videocardPrice;
            double totalCpuPrice = totalVideocardPrice * 0.35;
            double totalRamMemoryPrice = totalVideocardPrice * 0.10;

            double totalMoney = totalVideocardPrice + totalCpuPrice * numberCpu + totalRamMemoryPrice * numberRamMemory;

            if (numberVideocard > numberCpu)
            {
                totalMoney *= 0.85;
            }

            double difference = Math.Abs(totalMoney - budget);

            if (budget >= totalMoney)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }
        }
    }
}
