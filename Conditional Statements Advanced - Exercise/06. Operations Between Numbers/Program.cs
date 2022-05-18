using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN1 = int.Parse(Console.ReadLine());
            int numberN2 = int.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();

            switch (simbol)
            {
                case "+":
                    int sum = numberN1 + numberN2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{numberN1} + {numberN2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberN1} + {numberN2} = {sum} - odd");
                    }
                    break;
                case "-":
                    int sum2 = numberN1 - numberN2;
                    if (sum2 % 2 == 0)
                    {
                        Console.WriteLine($"{numberN1} - {numberN2} = {sum2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberN1} - {numberN2} = {sum2} - odd");
                    }
                    break;
                case "*":
                    int sum3 = numberN1 * numberN2;
                    if (sum3 % 2 == 0)
                    {
                        Console.WriteLine($"{numberN1} * {numberN2} = {sum3} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberN1} * {numberN2} = {sum3} - odd");
                    }
                    break;
                case "/":
                    if (numberN2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberN1} by zero");
                    }
                    else
                    {
                        double sum4 = numberN1 * 1.0 / numberN2;
                        Console.WriteLine($"{numberN1} / {numberN2} = {sum4:f2}");
                    }
                    break;
                case "%":
                    if (numberN2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberN1} by zero");
                    }
                    else
                    {
                        int sum5 = numberN1 % numberN2;
                        Console.WriteLine($"{numberN1} % {numberN2} = {sum5}");
                    }
                    break;
            }
        }
    }
}
