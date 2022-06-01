using System;

namespace _03._Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            int numFood = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());

            double price = 0;

            if (food == "Cake")
            {
                if (dayOfDecember <= 15)
                {
                    price = numFood * 24;
                }
                else if (15 < dayOfDecember)
                {
                    price = numFood * 28.70;
                }
            }
            else if (food == "Souffle")
            {
                if (dayOfDecember <= 15)
                {
                    price = numFood * 6.66;
                }
                else if (15 < dayOfDecember)
                {
                    price = numFood * 9.80;
                }
            }
            else if (food == "Baklava")
            {
                if (dayOfDecember <= 15)
                {
                    price = numFood * 12.60;
                }
                else if (15 < dayOfDecember)
                {
                    price = numFood * 16.98;
                }
            }

            if (dayOfDecember <= 22)
            {
                if (100 <= price && price <= 200) //15
                {
                    price *= 0.85;
                }
                else if (200 < price) //25
                {
                    price *= 0.75;
                }
                if (dayOfDecember <= 15) //10
                {
                    price *= 0.90;
                }
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
