using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double kVeget = double.Parse(Console.ReadLine());
            double kFruit = double.Parse(Console.ReadLine());
            double totallVeget = double.Parse(Console.ReadLine());
            double totallFruit = double.Parse(Console.ReadLine());

            double sumVeget = kVeget * totallVeget;
            double sumFruit = kFruit * totallFruit;

            double sumBgn = sumVeget + sumFruit;
            double sumEu = sumBgn / 1.94;

            Console.WriteLine("{0:f2}", sumEu);
        }
    }
}
