using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetFilm = double.Parse(Console.ReadLine());
            int personalNum = int.Parse(Console.ReadLine());
            double priceOnePersonal = double.Parse(Console.ReadLine());

            double percent = 0;
            double clothesTotal = 0;
            double totalAmountFilm = 0;

            double amountDecor = budgetFilm * 0.1;
            double amountClothes = personalNum * priceOnePersonal;
            totalAmountFilm = amountDecor + amountClothes;

            if (150 < personalNum)
            {
                percent = amountClothes * 0.1;
                clothesTotal = amountClothes - percent;
                totalAmountFilm = amountDecor + clothesTotal;
            }

            if (totalAmountFilm > budgetFilm)
            {
                double neededLv = Math.Abs(budgetFilm - totalAmountFilm);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededLv:f2} leva more.");
            }
            else if (budgetFilm >= totalAmountFilm)
            {
                
                double lvLeft = budgetFilm - totalAmountFilm;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {lvLeft:f2} leva left.");
            }
        }
    }
}
