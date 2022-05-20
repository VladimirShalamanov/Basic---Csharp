using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currenSymbol = text[i];

                if (currenSymbol == 'a')
                {
                    sum1++;
                }
                else if (currenSymbol == 'e')
                {
                    sum2 += 2;
                }
                else if (currenSymbol == 'i')
                {
                    sum3 += 3;
                }
                else if (currenSymbol == 'o')
                {
                    sum4 += 4;
                }
                else if (currenSymbol == 'u')
                {
                    sum5 += 5;
                }
            }

            int totalSum = sum1 + sum2 + sum3 + sum4 + sum5;
            Console.WriteLine(totalSum);
        }
    }
}
