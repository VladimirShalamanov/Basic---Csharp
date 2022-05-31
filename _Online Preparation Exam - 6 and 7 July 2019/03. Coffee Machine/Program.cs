using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double currentPrice = 0;
            double total = 0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    currentPrice = 0.90;
                }
                else if (sugar == "Normal")
                {
                    currentPrice = 1.00;
                }
                else if (sugar == "Extra")
                {
                    currentPrice = 1.20;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    currentPrice = 1.00;
                }
                else if (sugar == "Normal")
                {
                    currentPrice = 1.20;
                }
                else if (sugar == "Extra")
                {
                    currentPrice = 1.60;
                }
            }
            else if (drink == "Tea")
            {
                if (sugar == "Without")
                {
                    currentPrice = 0.50;
                }
                else if (sugar == "Normal")
                {
                    currentPrice = 0.60;
                }
                else if (sugar == "Extra")
                {
                    currentPrice = 0.70;
                }
            }

            total = num * currentPrice;

            if (sugar == "Without")
            {
                total -= total * 0.35;
            }
            if (drink == "Espresso" && 5 <= num)
            {
                total -= total * 0.25;
            }
            if (15 < total)
            {
                total -= total * 0.20;
            }

            Console.WriteLine($"You bought {num} cups of {drink} for {total:f2} lv.");
        }
    }
}
