using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrysanthemumsNum = double.Parse(Console.ReadLine());
            double rosesNum = double.Parse(Console.ReadLine());
            double tulipsNum = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string yOrN = Console.ReadLine();

            double sum = 0;
            double percentSum = 0;
            double totalMoney = 0;
            //20%

            if (season == "Spring") //5%
            {
                sum = chrysanthemumsNum * 2.00 + rosesNum * 4.10 + tulipsNum * 2.50;
                if (yOrN == "Y")
                {
                    percentSum = sum + (sum * 0.15);
                }
                else if (yOrN == "N")
                {
                    percentSum = sum;
                }
                if (7 < tulipsNum)
                {
                    percentSum = percentSum - (percentSum * 0.05);
                }
                if (20 < chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum - (percentSum * 0.2);
                }
                else if (20 > chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum;
                }
            }
            else if (season == "Summer")
            {
                sum = chrysanthemumsNum * 2.00 + rosesNum * 4.10 + tulipsNum * 2.50;
                if (yOrN == "Y")
                {
                    percentSum = sum + (sum * 0.15);
                }
                else if (yOrN == "N")
                {
                    percentSum = sum;
                }
                if (20 < chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum - (percentSum * 0.2);
                }
                else if (20 > chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum;
                }
            }
            else if (season == "Autumn")
            {
                sum = chrysanthemumsNum * 3.75 + rosesNum * 4.50 + tulipsNum * 4.15;
                if (yOrN == "Y")
                {
                    percentSum = sum + sum * 0.15;
                }
                else if (yOrN == "N")
                {
                    percentSum = sum;
                }
                if (20 < chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum - (percentSum * 0.2);
                }
                else if (20 > chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum;
                }
            }
            else if (season == "Winter") //10%
            {
                sum = chrysanthemumsNum * 3.75 + rosesNum * 4.50 + tulipsNum * 4.15;
                if (yOrN == "Y")
                {
                    percentSum = sum + sum * 0.15;
                }
                else if (yOrN == "N")
                {
                    percentSum = sum;
                }
                if (10 <= rosesNum)
                {
                    percentSum = percentSum - (percentSum * 0.10);
                }
                if (20 < chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum - (percentSum * 0.2);
                }
                else if (20 > chrysanthemumsNum + rosesNum + tulipsNum)
                {
                    totalMoney = percentSum;
                }
            }

            Console.WriteLine($"{2 + totalMoney:f2}");
        }
    }
}
