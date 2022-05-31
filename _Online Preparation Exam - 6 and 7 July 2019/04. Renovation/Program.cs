using System;

namespace _04._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            double num = double.Parse(Console.ReadLine());
            double percent = num / 100;
            string liters = Console.ReadLine();
            int count = 0;

            double sum = h * w * 4;
            double wallsPaint = sum - (sum * percent);
            int paiting = 0;

            while (liters != "Tired!")
            {
                count++;
                if (count == 1)
                {
                    paiting = (int)wallsPaint - int.Parse(liters);
                }
                else if (count == 2)
                {
                    paiting -= int.Parse(liters);
                }
                else if (count == 3)
                {
                    paiting -= int.Parse(liters);
                }
                if (paiting <= 0)
                {
                    break;
                }

                liters = Console.ReadLine();
            }

            if (liters == "Tired!")
            {
                Console.WriteLine($"{paiting} quadratic m left.");
            }
            else if (paiting < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(paiting)} l paint left!");
            }
            else if (paiting == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }

        }
    }
}
