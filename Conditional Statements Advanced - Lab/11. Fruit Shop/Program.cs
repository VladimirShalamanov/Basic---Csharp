using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruid = Console.ReadLine();
            string day = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());

            double totalSum = 0;
            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruid == "banana")
                {
                    price = 2.50;
                }
                else if (fruid == "apple")
                {
                    price = 1.20;
                }
                else if (fruid == "orange")
                {
                    price = 0.85;
                }
                else if (fruid == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruid == "kiwi")
                {
                    price = 2.70;
                }
                else if (fruid == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruid == "grapes")
                {
                    price = 3.85;
                }
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruid == "banana")
                {
                    price = 2.70;
                }
                else if (fruid == "apple")
                {
                    price = 1.25;
                }
                else if (fruid == "orange")
                {
                    price = 0.90;
                }
                else if (fruid == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruid == "kiwi")
                {
                    price = 3.00;
                }
                else if (fruid == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruid == "grapes")
                {
                    price = 4.20;
                }
            }

            if (price == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                totalSum = price * quality;
                Console.WriteLine($"{totalSum:f2}");
            }
        }
    }
}
