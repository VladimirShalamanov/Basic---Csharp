using System;

namespace _03._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());

            double f = (c * 1.8) + 32;

            Console.WriteLine("{0:f2}", f);
        }
    }
}
