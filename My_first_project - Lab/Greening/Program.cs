using System;

namespace Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetersGreening = double.Parse(Console.ReadLine());

            double finalPrice = 7.61 * squareMetersGreening;
            double discount = 0.18 * finalPrice;
            double finalPriceWithDiscount = finalPrice - discount;

            Console.WriteLine($"The final price is: {finalPriceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
