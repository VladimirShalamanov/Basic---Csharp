using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());
            double percent = days * 0.9;
            double hoursForWork = percent * 8;
            double overtime = numberWorkers * (2 * days);
            double totalHours = Math.Floor(hoursForWork + overtime);

            if (totalHours >= hours)
            {
                double hoursLeft = totalHours - hours;
                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else if (totalHours < hours)
            {
                double hoursNeeded = Math.Abs(totalHours - hours);
                Console.WriteLine($"Not enough time!{hoursNeeded} hours needed.");
            }
        }
    }
}
