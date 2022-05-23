using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoneyForHoliday = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int counterSpendDays = 0;
            int counterTotalDays = 0;

            while (currentMoney < neededMoneyForHoliday && counterSpendDays < 5)
            {
                string moneyMove = Console.ReadLine();
                double moneySpendOrSave = double.Parse(Console.ReadLine());
                counterTotalDays++;

                if (moneyMove == "spend")
                {
                    currentMoney -= moneySpendOrSave;
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }
                    counterSpendDays++;
                }
                else if (moneyMove == "save")
                {
                    currentMoney += moneySpendOrSave;
                    counterSpendDays = 0;
                }
            }

            if (counterSpendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterTotalDays);
            }
            if (currentMoney >= neededMoneyForHoliday)
            {
                Console.WriteLine($"You saved the money for {counterTotalDays} days.");
            }
        }
    }
}
