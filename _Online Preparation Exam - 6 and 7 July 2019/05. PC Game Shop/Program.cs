using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            int hearthstone = 0;
            int fornite = 0;
            int overwatch = 0;
            int others = 0;
            for (int i = 0; i < soldGames; i++)
            {
                string name = Console.ReadLine();

                if (name == "Hearthstone")
                {
                    hearthstone++;
                }
                else if (name == "Fornite")
                {
                    fornite++;
                }
                else if (name == "Overwatch")
                {
                    overwatch++;
                }
                else
                {
                    others++;
                }
            }

            double game1 = hearthstone * 1.0  / soldGames * 100;
            double game2 = fornite * 1.0 / soldGames * 100;
            double game3 = overwatch * 1.0 / soldGames * 100;
            double othersGames = others * 1.0 / soldGames * 100;

            Console.WriteLine($"Hearthstone - {game1:f2}%");
            Console.WriteLine($"Fornite - {game2:f2}%");
            Console.WriteLine($"Overwatch - {game3:f2}%");
            Console.WriteLine($"Others - {othersGames:f2}%");
        }
    }
}
