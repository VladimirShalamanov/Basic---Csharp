using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinNum = int.Parse(Console.ReadLine());
            double chineseAnNum = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine()) / 100;

            double bitcoin = 1168;
            double chineseAn = 0.15;
            double dollar = 1.76;
            double euro = 1.95;

            double bitcoinToBgn = bitcoin * bitcoinNum;
            double chineseAnToDollars = (chineseAnNum * chineseAn);
            double dollarsToBgn = chineseAnToDollars * dollar;
            double bgn = bitcoinToBgn + dollarsToBgn;
            double toEuro = bgn / euro;
            toEuro -= commission * toEuro;

            Console.WriteLine($"{toEuro:f2}");
        }
    }
}
