using System;

namespace _05._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTeam = Console.ReadLine();
            int numPlayGamesSeason = int.Parse(Console.ReadLine());

            int W = 0;
            int D = 0;
            int L = 0;

            for (int i = 1; i <= numPlayGamesSeason; i++)
            {
                string simbol = Console.ReadLine();

                if (simbol == "W")
                {
                    W++;
                }
                else if (simbol == "D")
                {
                    D++;
                }
                else if (simbol == "L")
                {
                    L++;
                }
            }

            int winPoitns = W * 3;
            int duuPoints = D * 1;
            int losePoints = L * 0;
            int totalPoitns = winPoitns + duuPoints;
            double percent = (W * 1.0) / (numPlayGamesSeason * 1.0) * 100;

            if (numPlayGamesSeason == 0)
            {
                Console.WriteLine($"{nameTeam} hasn't played any games during this season.");
            }
            else if (numPlayGamesSeason >= 1)
            {
                Console.WriteLine($"{nameTeam} has won {totalPoitns} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {W}");
                Console.WriteLine($"## D: {D}");
                Console.WriteLine($"## L: {L}");
                Console.WriteLine($"Win rate: {percent:f2}%");
            }
        }
    }
}
