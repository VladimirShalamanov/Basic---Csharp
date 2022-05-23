using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int allPicesOfCake = lenght * width;

            while (allPicesOfCake > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                int peaceOfCake = int.Parse(input);
                allPicesOfCake -= peaceOfCake;
            }

            if (allPicesOfCake >= 0)
            {
                Console.WriteLine($"{allPicesOfCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(allPicesOfCake)} pieces more.");
            }
        }
    }
}
