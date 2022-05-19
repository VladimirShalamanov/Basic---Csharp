using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int KM = int.Parse(Console.ReadLine());
            string partDay = Console.ReadLine();
            const double TAXI_START_PRICE = 0.70;
            const double TAXI_DAY_PRICE = 0.79;
            const double TAXI_NIGHT_PRICE = 0.90;
            const double BUS_DAY_NIGHT_PRICE = 0.09;
            const double TRAIN_DAY_NIGHT_PRICE = 0.06;
            double totalSum = 0;

            if (KM < 20)
            {
                if (partDay == "day")
                {
                    totalSum = TAXI_START_PRICE + (KM * TAXI_DAY_PRICE);
                }
                else if (partDay == "night")
                {
                    totalSum = TAXI_START_PRICE + (KM * TAXI_NIGHT_PRICE);
                }
            }
            else if (KM >= 20 && KM < 100)
            {
                if (partDay == "day" || partDay == "night")
                {
                    totalSum = KM * BUS_DAY_NIGHT_PRICE;
                }
            }
            else if (KM >= 100)
            {
                if (partDay == "day" || partDay == "night")
                {
                    totalSum = KM * TRAIN_DAY_NIGHT_PRICE;
                }
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
