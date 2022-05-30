using System;

namespace _03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string hallType = Console.ReadLine();
            int numPurchTickets = int.Parse(Console.ReadLine());

            double incomeScreeningFilm = 0;

            if (filmName == "A Star Is Born")
            {
                if (hallType == "normal")
                {
                    incomeScreeningFilm = numPurchTickets * 7.50;
                }
                else if (hallType == "luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 10.50;
                }
                else if (hallType == "ultra luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 13.50;
                }
            }
            else if (filmName == "Bohemian Rhapsody")
            {
                if (hallType == "normal")
                {
                    incomeScreeningFilm = numPurchTickets * 7.35;
                }
                else if (hallType == "luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 9.45;
                }
                else if (hallType == "ultra luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 12.75;
                }
            }
            else if (filmName == "Green Book")
            {
                if (hallType == "normal")
                {
                    incomeScreeningFilm = numPurchTickets * 8.15;
                }
                else if (hallType == "luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 10.25;
                }
                else if (hallType == "ultra luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 13.25;
                }
            }
            else if (filmName == "The Favourite")
            {
                if (hallType == "normal")
                {
                    incomeScreeningFilm = numPurchTickets * 8.75;
                }
                else if (hallType == "luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 11.55;
                }
                else if (hallType == "ultra luxury")
                {
                    incomeScreeningFilm = numPurchTickets * 13.95;
                }
            }

            Console.WriteLine($"{filmName} -> {incomeScreeningFilm:f2} lv.");
        }
    }
}
