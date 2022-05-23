using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradesCounter = 0;
            string problemName = Console.ReadLine();
            string lastProblem = "";
            int gradeSum = 0;
            int allGrade = 0;

            while (problemName != "Enough")
            {
                int currentGrade = int.Parse(Console.ReadLine());
                gradeSum++;
                allGrade += currentGrade;
                if (currentGrade <= 4)
                {
                    badGradesCounter++;
                    if (badGradesCounter == badGrades)
                    {
                        break;
                    }
                }

                lastProblem = problemName;
                problemName = Console.ReadLine();
            }

            if (problemName == "Enough")
            {
                double averageScore = 1.0 * allGrade / gradeSum;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {gradeSum}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            }
        }
    }
}
