using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());

            string name = Console.ReadLine();
            int num = 0;
            double price = 0;
            double sum = 0;
            double total = 0;
            while (true)
            {
                if (name == "Party!")
                {
                    Console.WriteLine($"We need {profit - total:f2} leva more.");
                    Console.WriteLine($"Club income - {total:f2} leva.");
                    break;
                }
                else if (total >= profit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {total:f2} leva.");
                    break;
                }

                num = int.Parse(Console.ReadLine());

                price = name.Length;
                sum = price * num;
                if (sum % 2 != 0)
                {
                    sum *= 0.75;
                }
                total += sum;

                name = Console.ReadLine();
            }

        }
    }
}
