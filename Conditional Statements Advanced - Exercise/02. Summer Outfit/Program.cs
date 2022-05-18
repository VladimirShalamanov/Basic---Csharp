using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degress = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            switch (timeOfDay)
            {
                case "Morning":
                    if (degress >= 10 && degress <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degress > 18 && degress <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degress >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    break;

                case "Afternoon":
                    if (degress >= 10 && degress <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degress > 18 && degress <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degress >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    break;

                case "Evening":
                    if (degress >= 10 && degress <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degress > 18 && degress <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degress >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
            }

        }
    }
}
