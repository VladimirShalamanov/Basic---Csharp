using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string step = Console.ReadLine();
            const int GOAL = 10000;
            int totalStep = 0;
            int stepGoHome = 0;

            while (totalStep < GOAL)
            {
                if (step != "Going home")
                {
                    totalStep += int.Parse(step);
                }
                else
                {
                    break;
                }

                if (totalStep < GOAL)
                {
                    step = Console.ReadLine();
                }
            }

            if (totalStep >= GOAL)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalStep - GOAL} steps over the goal!");
            }

            if (step == "Going home")
            {
                totalStep += int.Parse(Console.ReadLine());

                if (totalStep < GOAL)
                {
                    Console.WriteLine($"{GOAL - totalStep} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalStep - GOAL} steps over the goal!");
                }
            }
        }
    }
}
