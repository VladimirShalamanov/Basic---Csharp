using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double priceChickan = chickenMenu * 10.35;
            double priceFish = fishMenu * 12.40;
            double priceVegan = veganMenu * 8.15;

            double menuPrice = priceChickan + priceFish + priceVegan;
            double dessertPrice = menuPrice * 0.2;
            double deliveryPrice = 2.50;

            double sum = menuPrice + dessertPrice + deliveryPrice;

            Console.WriteLine(sum);
        }
    }
}
