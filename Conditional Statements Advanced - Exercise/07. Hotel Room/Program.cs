using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNight = int.Parse(Console.ReadLine());

            const double mayOktStudio = 50;
            const double mayOktApartment = 65;

            const double uSepStudio = 75.20;
            const double uSepApartment = 68.70;

            const double uAvgStudio = 76;
            const double uAvgApartment = 77;

            double totalPriceApartment = 0;
            double totalPriceStudio = 0;

            switch (month)
            {
                case "May":
                case "October":
                    totalPriceApartment = mayOktApartment * numNight;
                    totalPriceStudio = mayOktStudio * numNight;
                    if (numNight > 7 && numNight < 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.05;
                    }

                    else if (numNight > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.30;
                    }
                    break;

                case "June":
                case "September":
                    totalPriceApartment = uSepApartment * numNight;
                    totalPriceStudio = uSepStudio * numNight;
                    if (numNight > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.20;
                    }
                    break;

                case "July":
                case "August":
                    totalPriceApartment = uAvgApartment * numNight;
                    totalPriceStudio = uAvgStudio * numNight;
                    break;
            }

            if (numNight > 14)
            {
                totalPriceApartment -= totalPriceApartment * 0.10;
            }
            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");

        }
    }
}
