using System;

namespace _02._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = a * h / 2;

            Console.WriteLine("{0:f2}", area);
        }
    }
}
