using System;

namespace _10._Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {
                double numByTwo = number * 2;
                Console.WriteLine($"Result: {numByTwo:f2}");

                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative number!");
        }
    }
}
