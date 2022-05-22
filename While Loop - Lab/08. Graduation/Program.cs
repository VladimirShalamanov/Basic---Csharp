using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double grageSum = 0;
            int grade = 1;
            int failsCounter = 0;

            while (grade <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());

                if (yearlyGrade < 4)
                {
                    failsCounter++;
                    if (failsCounter == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                    continue;
                }

                grageSum += yearlyGrade;
                grade++;
            }

            double averageGrade = grageSum / 12;

            if (grade >= 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
