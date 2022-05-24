using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int studentsNum = int.Parse(Console.ReadLine());
            int nightNum = int.Parse(Console.ReadLine());

            string sport = "";
            double sum = 0;

            if (season == "Spring")
            {
                if (typeGroup == "girls")
                {
                    sport = "Athletics";
                    sum = studentsNum * 7.20 * nightNum;
                }
                else if (typeGroup == "boys")
                {
                    sport = "Tennis";
                    sum = studentsNum * 7.20 * nightNum;
                }
                else if (typeGroup == "mixed")
                {
                    sport = "Cycling";
                    sum = studentsNum * 9.50 * nightNum;
                }
            }

            else if (season == "Summer")
            {
                if (typeGroup == "girls")
                {
                    sport = "Volleyball";
                    sum = studentsNum * 15 * nightNum;
                }
                else if (typeGroup == "boys")
                {
                    sport = "Football";
                    sum = studentsNum * 15 * nightNum;
                }
                else if (typeGroup == "mixed")
                {
                    sport = "Swimming";
                    sum = studentsNum * 20 * nightNum;
                }
            }

            else if (season == "Winter")
            {
                if (typeGroup == "girls")
                {
                    sport = "Gymnastics";
                    sum = studentsNum * 9.60 * nightNum;
                }
                else if (typeGroup == "boys")
                {
                    sport = "Judo";
                    sum = studentsNum * 9.60 * nightNum;
                }
                else if (typeGroup == "mixed")
                {
                    sport = "Ski";
                    sum = studentsNum * 10 * nightNum;
                }
            }

            if (0 < sum)
            {
                if (50 <= studentsNum)
                {
                    sum *= 0.50;
                }
                else if (20 <= studentsNum && studentsNum < 50)
                {
                    sum *= 0.85;
                }
                else if (10 <= studentsNum && studentsNum < 20)
                {
                    sum *= 0.95;
                }

            }

            Console.WriteLine($"{sport} {sum:f2} lv.");
        }
    }
}
