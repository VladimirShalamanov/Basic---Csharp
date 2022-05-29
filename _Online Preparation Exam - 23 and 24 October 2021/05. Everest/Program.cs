using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int count = 1;
            int start = 5364;

            while (command != "END")
            {
                int m = int.Parse(Console.ReadLine());

                if (command == "Yes")
                {
                    count++;
                    start += m;
                }
                else if (command == "No")
                {
                    count += 0;
                    start += m;
                }
                if (start >= 8848)
                {
                    Console.WriteLine($"Goal reached for {count} days!");
                    break;
                }
                else if (5 <= count)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(start);
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "END")
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(start);
            }
        }
    }
}
