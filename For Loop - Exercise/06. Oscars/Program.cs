using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            const double NEEDED_POINTS_FOR_OSKAR = 1250.5;
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int countExamers = int.Parse(Console.ReadLine());

            double sumPoints = academyPoints;

            bool isActorFound = false;
            for (int integer = 0; integer < countExamers; integer++)
            {
                string nameOfJury = Console.ReadLine();
                double pointsOfJury = double.Parse(Console.ReadLine());

                double momentsPoints = (nameOfJury.Length * pointsOfJury) / 2;
                sumPoints += momentsPoints;
                if (sumPoints >= 1250.5)
                {
                    isActorFound = true;
                    break;
                }
            }

            if (isActorFound)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {sumPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {NEEDED_POINTS_FOR_OSKAR - sumPoints:f1} more!");
            }
        }
    }
}
