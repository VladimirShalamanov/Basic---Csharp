using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double footPrice = taxPerYear - 0.4 * taxPerYear;
            double outfitPrice = footPrice - 0.2 * footPrice;
            double ballPrace = outfitPrice / 4;
            double accPrice = ballPrace / 5;

            double expenses = taxPerYear + footPrice + outfitPrice + ballPrace + accPrice;

            Console.WriteLine(expenses);
        }
    }
}
