using System;

namespace _04._Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var kmStart = double.Parse(Console.ReadLine());

            double totalKm = kmStart;

            for (int i = 0; i < n; i++)
            {
                var kmPercent = double.Parse(Console.ReadLine());

                kmStart = kmStart + kmStart * (kmPercent / 100.00);
                totalKm += kmStart;
            }

            if (totalKm >= 1000)
            {
                double moreKm = Math.Ceiling(totalKm - 1000.00);
                Console.WriteLine($"You've done a great job running {moreKm} more kilometers!");
            }
            else
            {
                double neededKm = Math.Ceiling(1000.00 - totalKm);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {neededKm} more kilometers");
            }
        }
    }
}
