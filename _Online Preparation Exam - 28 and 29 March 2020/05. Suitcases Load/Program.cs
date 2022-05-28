using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int counter = 0;

            while (true)
            {
                if (command == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }
                double caseVolume = double.Parse(command);
                if ((counter + 1) % 3 == 0)
                {
                    caseVolume *= 1.1;
                }
                if (trunkCapacity < caseVolume)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                counter++;
                trunkCapacity -= caseVolume;

                command = Console.ReadLine();
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
