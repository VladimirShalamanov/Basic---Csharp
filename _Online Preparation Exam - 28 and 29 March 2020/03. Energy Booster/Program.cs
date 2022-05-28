using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderNum = int.Parse(Console.ReadLine());

            int small = 2;
            int big = 5;

            double smallWatermelon = 56;
            double bigWatermelon = 28.70;
            double smallMango = 36.66;
            double bigMango = 19.60;
            double smallPineapple = 42.10;
            double bigPineapple = 24.80;
            double smallRaspberry = 20;
            double bigRaspberry = 15.20;

            double price = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    price = small * smallWatermelon;
                }
                else if (size == "big")
                {
                    price = big * bigWatermelon;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    price = small * smallMango;
                }
                else if (size == "big")
                {
                    price = big * bigMango;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = small * smallPineapple;
                }
                else if (size == "big")
                {
                    price = big * bigPineapple;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price = small * smallRaspberry;
                }
                else if (size == "big")
                {
                    price = big * bigRaspberry;
                }
            }

            double totalPrice = orderNum * price;

            if (400 <= totalPrice && totalPrice <= 1000)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (1000 < totalPrice)
            {
                totalPrice -= totalPrice * 0.5;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
