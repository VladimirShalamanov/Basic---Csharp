using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int totalStudents = 0;
            int totalStandards = 0;
            int totalKids = 0;
            int totalTickets = 0;

            while (command != "Finish")
            {
                int students = 0;
                int standart = 0;
                int kid = 0;
                int freeSpots = int.Parse(Console.ReadLine());
                for (int i = 0; i < freeSpots; i++)
                {
                    string TicketType = Console.ReadLine();
                    if (TicketType == "End")
                    {
                        break;
                    }

                    switch (TicketType)
                    {
                        case "student":
                            students++;
                            break;
                        case "standard":
                            standart++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }

                }
                totalStudents += students;
                totalStandards += standart;
                totalKids += kid;
                double percentegFull = (students + standart + kid) / (double)freeSpots * 100;
                Console.WriteLine($"{command} - {percentegFull:f2}% full.");
                command = Console.ReadLine();
            }

            totalTickets = totalStudents + totalStandards + totalKids;
            Console.WriteLine($"Total tickets: {totalTickets}");
            double studentPercentage = totalStudents / (double) totalTickets * 100;
            double standartPercentage = totalStandards / (double) totalTickets * 100;
            double kidsPercentage = totalKids / (double) totalTickets * 100;
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidsPercentage:f2}% kids tickets.");
        }
    }
}
