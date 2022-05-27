using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameAvio = Console.ReadLine();
            int adultsTicket = int.Parse(Console.ReadLine());
            int kidsTicket = int.Parse(Console.ReadLine());
            double priceAdultsTicket = double.Parse(Console.ReadLine());
            double priceFeeService = double.Parse(Console.ReadLine());

            double priceKidTicket = priceAdultsTicket - (priceAdultsTicket * 0.7);
            double priceTicketAdultsFeeService = priceAdultsTicket + priceFeeService;
            double priceTicketKidFeeService = priceKidTicket + priceFeeService;
            double totalPrice = (kidsTicket * priceTicketKidFeeService) + (adultsTicket * priceTicketAdultsFeeService);
            double profit = totalPrice * 0.2;

            Console.WriteLine($"The profit of your agency from {nameAvio} tickets is {profit:f2} lv.");
        }
    }
}
