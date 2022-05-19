using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayForStay = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            const double ROOM_FOR_ONE_PERSON = 18;
            const double APARTMENT = 25;
            const double PRESIDENT_APARTMEN = 35;

            double discountPrice = 0;
            double finalPrice = 0;
            int night = dayForStay - 1;

            switch (typeRoom)
            {
                case "room for one person":
                    discountPrice = night * ROOM_FOR_ONE_PERSON;
                    break;

                case "apartment":
                    if (night < 10)
                    {
                        discountPrice = night * APARTMENT * 0.70;
                    }
                    else if (night >= 10 && night <= 15)
                    {
                        discountPrice = night * APARTMENT * 0.65;
                    }
                    else if (dayForStay > 15)
                    {
                        discountPrice = night * APARTMENT * 0.50;
                    }
                    break;
                case "president apartment":
                    if (night < 10)
                    {
                        discountPrice = night * PRESIDENT_APARTMEN * 0.90;
                    }
                    else if (night >= 10 && night <= 15)
                    {
                        discountPrice = night * PRESIDENT_APARTMEN * 0.85;
                    }
                    else if (dayForStay > 15)
                    {
                        discountPrice = night * PRESIDENT_APARTMEN * 0.80;
                    }
                    break;
            }

            if (feedback == "positive")
            {
                finalPrice = discountPrice * 1.25;
            }
            else if (feedback == "negative")
            {
                finalPrice = discountPrice * 0.90;
            }

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
