using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());

            double interestSum = depositSum * yearPercent / 100;
            double interestPerMonth = interestSum / 12;

            double totallSum = depositSum + depositPeriod * ((depositSum * yearPercent / 100) / 12);

            Console.WriteLine(totallSum);
        }
    }
}
