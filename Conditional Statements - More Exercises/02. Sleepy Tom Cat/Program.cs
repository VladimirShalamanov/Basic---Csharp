using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekendDays = int.Parse(Console.ReadLine());

            const int workPerson = 63;
            const int chillPerson = 127;
            const int oneYarDays = 365;
            const int playTom = 30000;

            double chillDays = weekendDays * chillPerson;
            double workDays = (oneYarDays - weekendDays) * workPerson;
            double totalTime = chillDays + workDays;

            double leftTime = playTom - totalTime;

            if (playTom < totalTime)
            {
                double hour1 = Math.Abs(leftTime / 60);
                double hour = Math.Floor(hour1);
                double minutes = Math.Abs(leftTime % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hour} hours and {minutes} minutes more for play");
            }
            else
            {
                double hour = Math.Floor(leftTime / 60);
                double minutes = leftTime % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hour} hours and {minutes} minutes less for play");
            }
        }
    }
}
