using System;

namespace Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPages = int.Parse(Console.ReadLine());
            int pagesHour = int.Parse(Console.ReadLine());
            int countDays = int.Parse(Console.ReadLine());

            int totalTime = countPages / pagesHour;
            int hoursPerDay = totalTime / countDays;

            Console.WriteLine(hoursPerDay);
        }
    }
}
