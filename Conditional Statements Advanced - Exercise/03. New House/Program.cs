using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            const double rosePrice = 5;
            const double dahliaPrice = 3.80;
            const double tulipPrice = 2.80;
            const double narcissusPrice = 3;
            const double gladiolusPrice = 2.50;

            double finalMoney = 0;

            switch (flowers)
            {
                case "Roses":
                    if (number > 80)
                    {
                        finalMoney -= number * rosePrice * 0.10;
                    }
                    finalMoney += number * rosePrice;
                    break;
                case "Dahlias":
                    if (number > 90)
                    {
                        finalMoney -= number * dahliaPrice * 0.15;
                    }
                    finalMoney += number * dahliaPrice;
                    break;
                case "Tulips":
                    if (number > 80)
                    {
                        finalMoney -= number * tulipPrice * 0.15;
                    }
                    finalMoney += number * tulipPrice;
                    break;
                case "Narcissus":
                    if (number < 120)
                    {
                        finalMoney += number * narcissusPrice * 0.15;
                    }
                    finalMoney += number * narcissusPrice;
                    break;
                case "Gladiolus":
                    if (number < 80)
                    {
                        finalMoney += number * gladiolusPrice * 0.20;
                    }
                    finalMoney += number * gladiolusPrice;
                    break;
            }
            if (budget >= finalMoney)
            {
                double moneyLeft = budget - finalMoney;
                Console.WriteLine($"Hey, you have a great garden with {number} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double needMoney = finalMoney - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:f2} leva more.");
            }
        }
    }
}
