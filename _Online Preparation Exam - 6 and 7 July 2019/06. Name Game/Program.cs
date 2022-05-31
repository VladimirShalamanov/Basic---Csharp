using System;

namespace _06._Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int count = 0;
            int firtsPoint = 0;
            int secondPoint = 0;
            string winner1 = "";
            string winner2 = "";

            while (name != "Stop")
            {
                int points = 0;
                count++;
                int letters = name.Length;
                int cou = 0;

                for (int i = 1; i <= letters; i++)
                {
                    cou++;
                    int num = int.Parse(Console.ReadLine());

                    if (cou == 1)
                    {
                        if (name[0] == num)
                        {
                            points += 10;
                        }
                        else if (name[0] != num)
                        {
                            points += 2;
                        }
                    }
                    else if (cou == 2)
                    {
                        if (name[1] == num)
                        {
                            points += 10;
                        }
                        else if (name[1] != num)
                        {
                            points += 2;
                        }
                    }
                    else if (cou == 3)
                    {
                        if (name[2] == num)
                        {
                            points += 10;
                        }
                        else if (name[2] != num)
                        {
                            points += 2;
                        }
                    }
                    else if (cou == 4)
                    {
                        if (name[3] == num)
                        {
                            points += 10;
                        }
                        else if (name[3] != num)
                        {
                            points += 2;
                        }
                    }
                    else if (cou == 5)
                    {
                        if (name[4] == num)
                        {
                            points += 10;
                        }
                        else if (name[4] != num)
                        {
                            points += 2;
                        }
                    }
                }
                if (count == 1)
                {
                    winner1 = name;
                    firtsPoint += points;
                }
                else if (count == 2)
                {
                    winner2 = name;
                    secondPoint += points;
                }
                name = Console.ReadLine();
            }

            if (firtsPoint > secondPoint)
            {
                Console.WriteLine($"The winner is {winner1} with {firtsPoint} points!");
            }
            else if (secondPoint > firtsPoint)
            {
                Console.WriteLine($"The winner is {winner2} with {secondPoint} points!");
            }
            else if (secondPoint == firtsPoint)
            {
                Console.WriteLine($"The winner is {winner2} with {secondPoint} points!");
            }
        }
    }
}