using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int filmsNum = int.Parse(Console.ReadLine());

            double maxRating = 0;
            double minRating = 11;

            string nameHighest = "";
            string nameLowest = "";
            //double highestRating = 0;
            //double lowestRating = 0;
            double sum = 0;

            for (int i = 0; i < filmsNum; i++)
            {
                string nameFilm = Console.ReadLine();
                double ratingFilm = double.Parse(Console.ReadLine());

                if (ratingFilm > maxRating)
                {
                    nameHighest = nameFilm;
                    maxRating = ratingFilm;
                }
                if (ratingFilm < minRating)
                {
                    nameLowest = nameFilm;
                    minRating = ratingFilm;
                }
                sum += ratingFilm;
            }

            double averageRating = sum / filmsNum;

            Console.WriteLine($"{nameHighest} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{nameLowest} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
