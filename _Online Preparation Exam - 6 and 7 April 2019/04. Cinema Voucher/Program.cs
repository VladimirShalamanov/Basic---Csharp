using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            int moviePrice = 0;
            int productPrice = 0;
            int tickets = 0;
            int products = 0;

            while (voucher >= 0)
            {
                string purchase = Console.ReadLine();
                int length = purchase.Length;
                if (purchase == "End")
                {
                    Console.WriteLine(tickets);
                    Console.WriteLine(products);
                    break;
                }
                if (length > 8)
                {
                    moviePrice = purchase[0] + purchase[1];
                    if (voucher < moviePrice)
                    {
                        Console.WriteLine(tickets);
                        Console.WriteLine(products);
                        break;
                    }
                    voucher -= moviePrice;
                    tickets++;
                }
                else if (length <= 8)
                {
                    productPrice = purchase[0];
                    if (voucher < productPrice)
                    {
                        Console.WriteLine(tickets);
                        Console.WriteLine(products);
                        break;
                    }
                    voucher -= productPrice;
                    products++;
                }
            }
        }
    }
}
