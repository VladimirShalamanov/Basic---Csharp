using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNylon = int.Parse(Console.ReadLine());
            int quantityPaint = int.Parse(Console.ReadLine());
            int quantityDiluent = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double priceBag = 0.40;
            double priceNylon = quantityNylon * 1.50 + 2 * 1.50;
            double pricePaint = (quantityPaint * 14.50 + 0.10 * quantityPaint * 14.50);
            double priceDiluent = quantityDiluent * 5;

            double pricePerHour = 0.30 * (priceBag + priceNylon + pricePaint + priceDiluent);
            double priceWorkers = workingHours * pricePerHour;

            double expenses = priceBag + priceNylon + pricePaint + priceDiluent + priceWorkers;
            Console.WriteLine(expenses);
        }
    }
}
