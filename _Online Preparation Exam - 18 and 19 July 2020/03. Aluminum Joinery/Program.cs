using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineryNum = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine();
            string methodDelivery = Console.ReadLine();

            double sum = 0;
            double sumDelivery = 0;
            double totalPrice = 0;

            if (typeJoinery == "90X130")
            {
                if (10 < joineryNum && joineryNum < 30)
                {
                    sum = joineryNum * 110;
                }
                else if (30 <= joineryNum && joineryNum < 60)
                {
                    sum = (joineryNum * 110) * 0.95;
                }
                else if (60 <= joineryNum)
                {
                    sum = (joineryNum * 110) * 0.92;
                }
            }
            else if (typeJoinery == "100X150")
            {
                if (10 < joineryNum && joineryNum < 40)
                {
                    sum = joineryNum * 140;
                }
                else if (40 <= joineryNum && joineryNum < 80)
                {
                    sum = (joineryNum * 140) * 0.94;
                }
                else if (80 <= joineryNum)
                {
                    sum = (joineryNum * 140) * 0.90;
                }
            }
            else if (typeJoinery == "130X180")
            {
                if (10 < joineryNum && joineryNum < 20)
                {
                    sum = joineryNum * 190;
                }
                else if (20 <= joineryNum && joineryNum < 50)
                {
                    sum = (joineryNum * 190) * 0.93;
                }
                else if (50 <= joineryNum)
                {
                    sum = (joineryNum * 190) * 0.88;
                }
            }
            else if (typeJoinery == "200X300")
            {
                if (10 < joineryNum && joineryNum < 25)
                {
                    sum = joineryNum * 250;
                }
                else if (25 <= joineryNum && joineryNum < 50)
                {
                    sum = (joineryNum * 250) * 0.91;
                }
                else if (50 <= joineryNum)
                {
                    sum = (joineryNum * 250) * 0.86;
                }
            }

            if (methodDelivery == "With delivery" && joineryNum > 10)
            {
                sumDelivery = sum + 60.00;
            }
            else if (methodDelivery == "Without delivery")
            {
                sumDelivery = sum;
            }

            if (joineryNum < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else if (99 < joineryNum)
            {
                totalPrice = sumDelivery * 0.96;
            }
            else if (joineryNum < 99)
            {
                totalPrice = sumDelivery;
            }

            if (0 < totalPrice)
            {
                Console.WriteLine($"{totalPrice:f2} BGN");
            }
        }
    }
}
