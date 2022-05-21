using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            int priceSingleToy = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int totalMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                money += 5;
                if (i % 2 == 0)
                {
                    totalMoney += money - 1;
                }
                else
                {
                    toys++;
                }
            }

            totalMoney += toys * priceSingleToy;

            if (totalMoney >= machinePrice)
            {
                Console.WriteLine($"Yes! {totalMoney - machinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {machinePrice - totalMoney:f2}");
            }
        }
    }
}
