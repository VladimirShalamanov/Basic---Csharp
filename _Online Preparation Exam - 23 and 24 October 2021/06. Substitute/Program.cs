using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int first1start = int.Parse(Console.ReadLine());
            int first2start = int.Parse(Console.ReadLine());
            int second1start = int.Parse(Console.ReadLine());
            int second2start = int.Parse(Console.ReadLine());

            for (int first1 = first1start; first1 <= 8; first1++)
            {
                int k = first1;
                for (int first2 = 9; first2 >= first2start; first2--)
                {
                    int l = first2;
                    if (k % 2 == 0 && l % 2 != 0)
                    {
                        for (int num1 = second1start; num1 <= 8; num1++)
                        {
                            int m = num1;
                            for (int num2 = 9; num2 >= second2start; num2--)
                            {
                                int n = num2;
                                if (m % 2 == 0 && n % 2 != 0)
                                {
                                    if (k == m && l == n)
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{k}{l} - {m}{n}");
                                    }
                                }
                            }
                        }

                    }

                }
            }
        }
    }
}
