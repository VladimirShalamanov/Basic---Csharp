using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            const double VIP = 499.99;
            const double NORMAL = 249.99;

            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleNumber = int.Parse(Console.ReadLine());

            double sum = 0;
            double neededMoney = 0;
            double leftMoney = 0;

            if (peopleNumber > 0)
            {
                if (1 <= peopleNumber && peopleNumber <= 4) //75%
                {
                    budget *= 0.25;
                }
                else if (5 <= peopleNumber && peopleNumber <= 9) //60%
                {
                    budget *= 0.4;
                }
                else if (10 <= peopleNumber && peopleNumber <= 24) //50%
                {
                    budget *= 0.5;
                }
                else if (25 <= peopleNumber && peopleNumber <= 49) //40%
                {
                    budget *= 0.6;
                }
                else if (50 <= peopleNumber) //25%
                {
                    budget *= 0.75;
                }
            }

            if (category == "VIP")
            {
                sum = VIP * peopleNumber;
                if (sum > budget)
                {
                    neededMoney = sum - budget;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
                }
                else if (sum < budget)
                {
                    leftMoney = budget - sum;
                    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
                }
            }
            else if (category == "Normal")
            {
                sum = NORMAL * peopleNumber;
                if (sum > budget)
                {
                    neededMoney = sum - budget;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
                }
                else if (sum < budget)
                {
                    leftMoney = budget - sum;
                    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
                }
            }
        }
    }
}
