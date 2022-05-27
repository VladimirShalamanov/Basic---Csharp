using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBagsOver20 = double.Parse(Console.ReadLine());
            double kgBags = double.Parse(Console.ReadLine());
            int daysToTrip = int.Parse(Console.ReadLine());
            int numBags = int.Parse(Console.ReadLine());

            double priceBags = 0;
            double sum = 0;
            double totalPrice = 0;

            if (kgBags < 10)
            {
                priceBags = priceBagsOver20 * 0.2;
            }
            else if (10 <= kgBags && kgBags <= 20)
            {
                priceBags = priceBagsOver20 / 2;
            }
            else if (20 < kgBags)
            {
                priceBags = priceBagsOver20;
            }


            if (30 < daysToTrip)
            {
                sum = priceBags + (priceBags * 0.10);
            }
            else if (7 <= daysToTrip && daysToTrip <= 30)
            {
                sum = priceBags + (priceBags * 0.15);
            }
            else if (daysToTrip < 7)
            {
                sum = priceBags + (priceBags * 0.40);
            }

            totalPrice = sum * numBags;
            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv. ");
        }
    }
}
