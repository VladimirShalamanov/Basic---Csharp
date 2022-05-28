using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSecPerOneMeter = double.Parse(Console.ReadLine());

            double totalSec = distanceMeters * timeSecPerOneMeter;
            double addSec = (Math.Floor (distanceMeters / 50)) * 30;
            double totalTime = totalSec + addSec;

            if (totalTime  < recordSec)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                double neededTime = totalTime - recordSec;
                Console.WriteLine($"No! He was {neededTime:f2} seconds slower.");
            }
        }
    }
}
