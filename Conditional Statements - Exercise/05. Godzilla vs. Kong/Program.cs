using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            int stunman = int.Parse(Console.ReadLine());
            double priceForClothesPerson = double.Parse(Console.ReadLine());

            double decorPrice = budge * 0.10;
            double totalPriceForClothes = stunman * priceForClothesPerson;

            if (stunman > 150)
            {
                totalPriceForClothes *= 0.90;
            }

            double totalMoney = decorPrice + totalPriceForClothes;

            if (totalMoney > budge)
            {
                double neededMoney = totalMoney - budge;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budge - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
