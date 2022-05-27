using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double points = 0;
            double red = 0;
            double orange = 0;
            double yellow = 0;
            double white = 0;
            int otherColors = 0;
            double black = 0;

            for (int i = 1; i <= n; i++)
            {
                string colorsBalls = Console.ReadLine();
                if (colorsBalls == "red")
                {
                    points += 5;
                    red++;
                }
                else if (colorsBalls == "orange")
                {
                    points += 10;
                    orange++;
                }
                else if (colorsBalls == "yellow")
                {
                    points += 15;
                    yellow++;
                }
                else if (colorsBalls == "white")
                {
                    points += 20;
                    white++;
                }
                else if (colorsBalls == "black")
                {
                    points = Math.Floor(points / 2);
                    black++;
                }
                else
                {
                    otherColors++;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {red}");
            Console.WriteLine($"Points from orange balls: {orange}");
            Console.WriteLine($"Points from yellow balls: {yellow}");
            Console.WriteLine($"Points from white balls: {white}");
            Console.WriteLine($"Other colors picked: {otherColors}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
