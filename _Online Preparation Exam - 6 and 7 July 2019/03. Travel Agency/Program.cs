using System;

namespace _03._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string type = Console.ReadLine();
            string VIP = Console.ReadLine();
            int daysStay = int.Parse(Console.ReadLine());

            double currentPrice = 0;

            if (city == "Bansko" || city == "Borovets")
            {
                if (type == "withEquipment")
                {
                    currentPrice = 100;
                }
                else if (type == "noEquipment")
                {
                    currentPrice = 80;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (type == "withBreakfast")
                {
                    currentPrice = 130;
                }
                else if (type == "noBreakfast")
                {
                    currentPrice = 100;
                }
            }

            if (VIP == "no")
            {
                currentPrice += 0;
            }

            else if (VIP == "yes")
            {
                if (city == "Bansko" || city == "Borovets")
                {
                    if (type == "withEquipment")
                    {
                        currentPrice *= 0.90;
                    }
                    else if (type == "noEquipment")
                    {
                        currentPrice *= 0.95;
                    }
                }
                else if (city == "Varna" || city == "Burgas")
                {
                    if (type == "withBreakfast")
                    {
                        currentPrice *= 0.88;
                    }
                    else if (type == "noBreakfast")
                    {
                        currentPrice *= 0.93;
                    }
                }
            }

            double total = currentPrice * daysStay;

            if (daysStay > 7)
            {
                total -= currentPrice;
            }
            if (daysStay <= 0)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (daysStay > 0 && city == "Bansko" || city == "Borovets" || city == "Varna" || city == "Burgas" && type == "noEquipment" || type == "withEquipment" || type == "noBreakfast" || type == "withBreakfast" && VIP == "no" || VIP == "yes")
            {
                Console.WriteLine($"The price is {currentPrice:f2}lv! Have a nice time!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
