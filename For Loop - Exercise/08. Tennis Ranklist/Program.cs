using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int winner = 2000;
            const int finalist = 1200;
            const int semiFinalist = 720;
            int numberTour = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int points = 0;
            double average = 0.0;
            double percent = 0;
            int numberOfWonTour = 0;
            points = startPoints;

            for (int i = 0; i < numberTour; i++)
            {
                string stageTour = Console.ReadLine();

                if (stageTour == "F")
                {
                    points += finalist;
                }
                else if (stageTour == "W")
                {
                    points += winner;
                    numberOfWonTour++;
                }
                else if (stageTour == "SF")
                {
                    points += semiFinalist;
                }
            }
            average = (points - startPoints) / numberTour;
            percent = ((double)numberOfWonTour / numberTour) * 100;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
