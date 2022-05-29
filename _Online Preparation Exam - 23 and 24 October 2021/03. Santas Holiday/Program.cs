using System;

namespace _03._Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysHoliday = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string evalu = Console.ReadLine();

            double priceStay = 0;
            int totalNight = daysHoliday - 1;

            if (typeRoom == "room for one person")
            {
                priceStay = totalNight * 18.00;
            }
            else if (totalNight < 10)
            {
                if (typeRoom == "apartment")
                {
                    priceStay = totalNight * 25.00;
                    priceStay -= priceStay * 0.30;
                }
                else if (typeRoom == "president apartment")
                {
                    priceStay = totalNight * 35.00;
                    priceStay -= priceStay * 0.10;
                }
            }
            else if (10 <= totalNight && totalNight <= 15)
            {
                if (typeRoom == "apartment")
                {
                    priceStay = totalNight * 25.00;
                    priceStay -= priceStay * 0.35;
                }
                else if (typeRoom == "president apartment")
                {
                    priceStay = totalNight * 35.00;
                    priceStay -= priceStay * 0.15;
                }
            }
            else if (15 < totalNight)
            {
                if (typeRoom == "apartment")
                {
                    priceStay = totalNight * 25.00;
                    priceStay -= priceStay * 0.50;
                }
                else if (typeRoom == "president apartment")
                {
                    priceStay = totalNight * 35.00;
                    priceStay -= priceStay * 0.20;
                }
            }

            if (evalu == "positive")
            {
                priceStay *= 1.25;
                Console.WriteLine($"{priceStay:f2}");
            }
            else if (evalu == "negative")
            {
                priceStay -= priceStay * 0.10;
                Console.WriteLine($"{priceStay:f2}");
            }
        }
    }
}
