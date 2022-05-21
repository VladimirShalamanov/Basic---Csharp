using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int interator = 0; interator <= openedTabs; interator++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

                string browserTab = Console.ReadLine();
                if (browserTab == "Facebook")
                {
                    salary -= FACEBOOK;
                }
                else if (browserTab == "Instagram")
                {
                    salary -= INSTAGRAM;
                }
                else if (browserTab == "Reddit")
                {
                    salary -= REDDIT;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
