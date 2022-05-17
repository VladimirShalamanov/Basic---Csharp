using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());

            double commissions = 0;

            if (0 <= sale && sale <= 500)
            {
                if (city == "Sofia")
                {
                    commissions = sale * 0.05;
                }
                else if (city == "Varna")
                {
                    commissions = sale * 0.045;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sale * 0.055;
                }
            }

            else if (500 < sale && sale <= 1000)
            {
                if (city == "Sofia")
                {
                    commissions = sale * 0.07;
                }
                else if (city == "Varna")
                {
                    commissions = sale * 0.075;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sale * 0.08;
                }
            }

            else if (1000 < sale && sale <= 10000)
            {
                if (city == "Sofia")
                {
                    commissions = sale * 0.08;
                }
                else if (city == "Varna")
                {
                    commissions = sale * 0.10;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sale * 0.12;
                }
            }

            else if (sale > 10000)
            {
                if (city == "Sofia")
                {
                    commissions = sale * 0.12;
                }
                else if (city == "Varna")
                {
                    commissions = sale * 0.13;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sale * 0.145;
                }
            }

            if (commissions == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{commissions:f2}");
            }
        }
    }
}
