using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsBike = int.Parse(Console.ReadLine());
            int seniorsBike = int.Parse(Console.ReadLine());
            string typeRace = Console.ReadLine();

            double sum = 0;

            if (typeRace == "trail")
            {
                sum = juniorsBike * 5.5 + seniorsBike * 7;
                sum *= 0.95;
            }
            else if (typeRace == "cross-country")
            {
                if (50 <= juniorsBike + seniorsBike)
                {
                    sum = juniorsBike * 8 + seniorsBike * 9.5;
                    sum *= 0.95;
                    sum *= 0.75;
                }
                else
                {
                    sum = juniorsBike * 8 + seniorsBike * 9.5;
                    sum *= 0.95;
                }
            }
            else if (typeRace == "downhill")
            {
                sum = juniorsBike * 12.25 + seniorsBike * 13.75;
                sum *= 0.95;
            }
            else if (typeRace == "road")
            {
                sum = juniorsBike * 20 + seniorsBike * 21.50;
                sum *= 0.95;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
