using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double GASOLINE_FOR_LITER = 2.22;
            const double DIESEL_FOR_LITER = 2.33;
            const double GAS_FOR_LITER = 0.93;

            const double GASOLINE_DISCOUNTS_FOR_LITER = 0.18;
            const double DIESEL_DISCOUNTS_FOR_LITER = 0.12;
            const double GAS_DISCOUNTS_FOR_LITER = 0.08;

            string fuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double sum = 0;

            if (fuel == "Gas")
            {
                if (clubCard == "Yes")
                {
                    sum = (GAS_FOR_LITER - GAS_DISCOUNTS_FOR_LITER) * litersFuel;

                    if (20 <= litersFuel && litersFuel <= 25)
                    {
                        sum *= 0.92;
                    }

                    else if (25 < litersFuel)
                    {
                        sum *= 0.9;
                    }
                }

                else if (clubCard == "No")
                {
                    sum = GAS_FOR_LITER * litersFuel;

                    if (20 <= litersFuel && litersFuel <= 25)
                    {
                        sum *= 0.92;
                    }

                    else if (25 < litersFuel)
                    {
                        sum *= 0.9;
                    }
                }
            }

            if (fuel == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    sum = (DIESEL_FOR_LITER - DIESEL_DISCOUNTS_FOR_LITER) * litersFuel;

                    if (20 <= litersFuel && litersFuel <= 25)
                    {
                        sum *= 0.92;
                    }

                    else if (25 < litersFuel)
                    {
                        sum *= 0.9;
                    }
                }

                else if (clubCard == "No")
                {
                    sum = DIESEL_FOR_LITER * litersFuel;

                    if (20 <= litersFuel && litersFuel <= 25)
                    {
                        sum *= 0.92;
                    }

                    else if (25 < litersFuel)
                    {
                        sum *= 0.9;
                    }
                }
            }

            if (fuel == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    sum = (GASOLINE_FOR_LITER - GASOLINE_DISCOUNTS_FOR_LITER) * litersFuel;

                    if (20 <= litersFuel && litersFuel <= 25)
                    {
                        sum *= 0.92;
                    }

                    else if (25 < litersFuel)
                    {
                        sum *= 0.9;
                    }
                }

                else if (clubCard == "No")
                {
                    sum = GASOLINE_FOR_LITER * litersFuel;

                    if (20 <= litersFuel && litersFuel <= 25)
                    {
                        sum *= 0.92;
                    }

                    else if (25 < litersFuel)
                    {
                        sum *= 0.9;
                    }
                }
            }

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
