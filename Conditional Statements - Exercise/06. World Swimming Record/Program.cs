using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recSec = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSec = double.Parse(Console.ReadLine());

            double totalSec = distanceMeters * timeSec;
            double addSec = Math.Floor(distanceMeters / 15) * 12.5;
            double totalTime = (totalSec + addSec);

            if (totalTime < recSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

            else
            {
                double needTime = totalTime - recSec;
                Console.WriteLine($"No, he failed! He was {needTime:f2} seconds slower.");
            }
        }
    }
}
