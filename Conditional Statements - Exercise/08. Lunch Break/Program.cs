using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvSeries = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            double holiday = double.Parse(Console.ReadLine());

            double timeLunch = holiday / 8;
            double timeRest = holiday / 4;
            double timeLeft = holiday - (timeLunch + timeRest);
            double neededTime = Math.Abs(episode - timeLeft);

            Console.WriteLine(timeLeft >= episode ? $"You have enough time to watch {tvSeries} and left with {Math.Ceiling(neededTime)} minutes free time." : $"You don't have enough time to watch {tvSeries}, you need {Math.Ceiling(neededTime)} more minutes.");
        }
    }
}
