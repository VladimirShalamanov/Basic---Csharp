using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);

                if (currentNum < min)
                {
                    min = currentNum;
                }
                else if (currentNum > max)
                {
                    max = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
