using System;

namespace _06._Max_Number
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

                if (currentNum > max)
                {
                    max = currentNum;
                }
                else if (currentNum < min)
                {
                    min = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
