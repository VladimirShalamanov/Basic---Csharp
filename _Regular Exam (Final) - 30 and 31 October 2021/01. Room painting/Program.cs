using System;

namespace _01._Room_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            int boxPaint = int.Parse(Console.ReadLine());
            int numTapet = int.Parse(Console.ReadLine());
            double priceFingers = double.Parse(Console.ReadLine());
            double priceBrush = double.Parse(Console.ReadLine());

            double totalPaint = 21.50 * boxPaint;
            double priceTapet = 5.20 * numTapet;
            double neededFingers = Math.Ceiling(numTapet * 0.35);
            double neededBrush = Math.Floor(boxPaint * 0.48);
            double totalPriceFingers = neededFingers * priceFingers;
            double totalPriceBrush = neededBrush * priceBrush;
            double sumProducts = totalPaint + priceTapet + totalPriceFingers + totalPriceBrush;
            double delivery = sumProducts / 15;

            Console.WriteLine($"This delivery will cost {delivery:f2} lv.");
        }
    }
}
