using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumOfPrimeNumber = 0;
            int sumOfNonPrimeNumber = 0;
            while (command != "stop")
            {
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        sumOfPrimeNumber += number;
                    }
                    else
                    {
                        sumOfNonPrimeNumber += number;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNumber}");
        }
    }
}
