using System;

namespace _08._TimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            minutesExam += hourExam * 60;
            minutesArrival += hourArrival * 60;

            if (minutesArrival > minutesExam)
            {
                Console.WriteLine("Late");
                difference = minutesArrival - minutesExam;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (minutesArrival < minutesExam - 30)
            {
                Console.WriteLine("Early");
                difference = minutesExam - minutesArrival;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{ hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = minutesExam - minutesArrival;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
