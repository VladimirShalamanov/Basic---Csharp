using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double magnolias = 3.25;
            const double hyacinths = 4.00;
            const double roses = 3.50;
            const double cacti = 8.00;

            int numberMagnolias = int.Parse(Console.ReadLine());
            int numberHyacinths = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberCacti = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double sum = (numberMagnolias * magnolias) + (numberHyacinths * hyacinths) + (numberRoses * roses) + (numberCacti * cacti);
            double totalSumWithTaxes = sum - (sum * 0.05);

            if (totalSumWithTaxes >= giftPrice)
            {
                double lvLeft = Math.Floor(totalSumWithTaxes - giftPrice);
                Console.WriteLine($"She is left with {lvLeft} leva.");
            }
            else
            {
                double lvNotReached = Math.Ceiling(giftPrice - totalSumWithTaxes);
                Console.WriteLine($"She will have to borrow {lvNotReached} leva.");
            }
        }
    }
}
