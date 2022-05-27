using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_score = int.MinValue;
            string current_name = "";
            string max_name = "";

            string name = Console.ReadLine();
            while (name != "END")
            {
                int goal = int.Parse(Console.ReadLine());
                current_name = name;

                if (goal > max_score)
                {
                    max_score = goal;
                    max_name = current_name;
                }
                if (goal >= 10)
                {
                    break;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{max_name} is the best player!");

            if (max_score >= 3)
            {
                Console.WriteLine($"He has scored {max_score} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {max_score} goals.");
            }
        }
    }
}
