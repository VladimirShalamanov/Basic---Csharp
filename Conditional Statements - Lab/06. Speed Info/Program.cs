using System;

namespace _06._Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number <= 10)
            {
                Console.WriteLine("slow");
            }

            if (number > 10 && number <= 50)
            {
                Console.WriteLine("average");
            }

            if (number > 50 && number <= 150)
            {
                Console.WriteLine("fast");
            }

            if (number > 150 && number <= 1000)
            {
                Console.WriteLine("ultra fast");
            }

            if (number > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
