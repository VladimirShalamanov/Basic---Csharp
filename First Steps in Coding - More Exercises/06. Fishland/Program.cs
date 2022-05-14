using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            Double mackerel = double.Parse(Console.ReadLine());
            Double spratFish = double.Parse(Console.ReadLine());
            Double bonito = double.Parse(Console.ReadLine());
            Double horseMackerel = double.Parse(Console.ReadLine());
            Double mussels = double.Parse(Console.ReadLine());

            double bonitoPrice = mackerel + mackerel * 0.60;
            double bonitoAmount = bonito * bonitoPrice;
            double horseMackerelPrice = spratFish + spratFish * 0.80;
            double horseMackerelAmount = horseMackerel * horseMackerelPrice;
            double musselsAmount = mussels * 7.50;
            double total = (bonitoAmount + horseMackerelAmount + musselsAmount);

            Console.WriteLine($"{total:F2}");
        }
    }
}
