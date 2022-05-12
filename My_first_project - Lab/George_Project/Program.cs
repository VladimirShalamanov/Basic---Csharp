using System;

namespace ArchitectProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = (Console.ReadLine());
            int project = int.Parse(Console.ReadLine());
            int hoursneed = 3;
            int totalhoursneed = hoursneed * project;
            Console.WriteLine($"The architect {name} will need {totalhoursneed} hours to complete {project} project/s.");
        }
    }
}