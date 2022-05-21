using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsOfPeoples = int.Parse(Console.ReadLine());

            int groupe1 = 0;
            int groupe2 = 0;
            int groupe3 = 0;
            int groupe4 = 0;
            int groupe5 = 0;

            for (int i = 1; i <= groupsOfPeoples; i++)
            {
                int climbersCount = int.Parse(Console.ReadLine());

                if (climbersCount < 6)
                {
                    groupe1 += climbersCount;
                }
                else if (climbersCount < 13)
                {
                    groupe2 += climbersCount;
                }
                else if (climbersCount < 26)
                {
                    groupe3 += climbersCount;
                }
                else if (climbersCount < 41)
                {
                    groupe4 += climbersCount;
                }
                else
                {
                    groupe5 += climbersCount;
                }
            }

            int totalClimbersCount = groupe1 + groupe2 + groupe3 + groupe4 + groupe5;

            double convertgroup1 = 1.0 * groupe1 / totalClimbersCount * 100;
            double convertgroup2 = 1.0 * groupe2 / totalClimbersCount * 100;
            double convertgroup3 = 1.0 * groupe3 / totalClimbersCount * 100;
            double convertgroup4 = 1.0 * groupe4 / totalClimbersCount * 100;
            double convertgroup5 = 1.0 * groupe5 / totalClimbersCount * 100;

            Console.WriteLine($"{convertgroup1:f2}%");
            Console.WriteLine($"{convertgroup2:f2}%");
            Console.WriteLine($"{convertgroup3:f2}%");
            Console.WriteLine($"{convertgroup4:f2}%");
            Console.WriteLine($"{convertgroup5:f2}%");
        }
    }
}
