using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            int counterBook = 0;
            string currentBook = Console.ReadLine();

            while (currentBook != "No More Books")
            {
                if (currentBook == searchBook)
                {
                    Console.WriteLine($"You checked {counterBook} books and found it.");
                    break;
                }
                counterBook++;
                currentBook = Console.ReadLine();
            }
            if (currentBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterBook} books.");
            }
        }
    }
}
