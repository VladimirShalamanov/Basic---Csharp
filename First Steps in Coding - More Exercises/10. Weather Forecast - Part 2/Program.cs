using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degress = double.Parse(Console.ReadLine());

            if (degress >= 26.00 && degress <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degress >= 20.1 && degress <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degress >= 15.00  && degress <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degress >= 12.00 && degress <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degress >= 5.00 && degress <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
