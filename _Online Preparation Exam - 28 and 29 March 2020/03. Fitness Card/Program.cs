using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumAvalible = double.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double fee = 0;

            if (simbol == "m")
            {
                if (sport == "Gym")
                {
                    fee = 42;
                }
                else if (sport == "Boxing")
                {
                    fee = 41;
                }
                else if (sport == "Yoga")
                {
                    fee = 45;
                }
                else if (sport == "Zumba")
                {
                    fee = 34;
                }
                else if (sport == "Dances")
                {
                    fee = 51;
                }
                else if (sport == "Pilates")
                {
                    fee = 39;
                }
            }

            else if (simbol == "f")
            {
                if (sport == "Gym")
                {
                    fee = 35;
                }
                else if (sport == "Boxing")
                {
                    fee = 37;
                }
                else if (sport == "Yoga")
                {
                    fee = 42;
                }
                else if (sport == "Zumba")
                {
                    fee = 31;
                }
                else if (sport == "Dances")
                {
                    fee = 53;
                }
                else if (sport == "Pilates")
                {
                    fee = 37;
                }
            }

            if (age <= 19)
            {
                fee -= fee * 0.2;
            }

            if (fee <= sumAvalible)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if(sumAvalible <= fee)
            {
                double money = fee - sumAvalible;
                Console.WriteLine($"You don't have enough money! You need ${money:f2} more.");
            }
        }
    }
}
