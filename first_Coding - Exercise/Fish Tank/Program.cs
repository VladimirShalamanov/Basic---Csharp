using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double liters = volume * 0.001;
            double space = percent / 100;
            double needLiters = liters * (1 - space);

            Console.WriteLine($"{needLiters:F3}");
        }
    }
}
