using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNum = int.Parse(Console.ReadLine());

            int COUNT_WIN = 0;
            int COUNT_LOSE = 0;
            double total = 0;

            for (int i = 1; i <= daysNum; i++)
            {
                double sum = 0;
                int counterWin = 0;
                int counterLose = 0;
                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string winLose = Console.ReadLine();

                    if (winLose == "win")
                    {
                        sum += 20;
                        counterWin++;
                        COUNT_WIN++;
                    }
                    else if (winLose == "lose")
                    {
                        sum += 0;
                        counterLose++;
                        COUNT_LOSE++;
                    }

                    sport = Console.ReadLine();
                }

                if (counterLose < counterWin)
                {
                    sum *= 1.1;
                }
                total += sum;
            }

            if (COUNT_LOSE < COUNT_WIN)
            {
                total *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {total:f2}");
            }
            else if (COUNT_WIN < COUNT_LOSE)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {total:f2}");
            }
        }
    }
}
