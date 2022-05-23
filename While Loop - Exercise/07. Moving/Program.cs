using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;

            int sumOfCubMeters = 0;
            string command = Console.ReadLine();
            while (command != "Done")
            {
                int currentCubicMeters = int.Parse(command);
                sumOfCubMeters += currentCubicMeters;
                if (freeSpace < sumOfCubMeters)
                {
                    int neededCubMeters = sumOfCubMeters - freeSpace;
                    Console.WriteLine($"No more free space! You need {neededCubMeters} Cubic meters more.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Done")
            {
                int freecubMeters = freeSpace - sumOfCubMeters;
                Console.WriteLine($"{freecubMeters} Cubic meters left.");
            }
        }
    }
}
