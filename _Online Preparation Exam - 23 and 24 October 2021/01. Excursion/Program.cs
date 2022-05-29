using System;

namespace _01._Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            int nighNum = int.Parse(Console.ReadLine());
            int cardNum = int.Parse(Console.ReadLine());
            int ticketNum = int.Parse(Console.ReadLine());

            double nughts = nighNum * 20;
            double cardDelivery = cardNum * 1.60;
            double ticketsMuseum = ticketNum * 6;
            double onePerson = nughts + cardDelivery + ticketsMuseum;
            double totalForGroup = onePerson * peopleNum;
            double percentegeSum = totalForGroup * 1.25;

            Console.WriteLine($"{percentegeSum:f2}");
        }
    }
}
