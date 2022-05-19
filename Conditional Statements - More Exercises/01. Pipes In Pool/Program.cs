using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipesP1 = int.Parse(Console.ReadLine());
            int pipesP2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double totalP1 = pipesP1 * hours;
            double totalP2 = pipesP2 * hours;

            double totalLiters = totalP1 + totalP2;

            double pipeFull = (totalLiters / volume) * 100.00;
            double pipe1 = (totalP1 / totalLiters) * 100.00;
            double pipe2 = (totalP2 / totalLiters) * 100.00;

            double overWater = totalLiters - volume;

            if (totalLiters <= volume)
            {
                Console.WriteLine($"The pool is {pipeFull}% full. Pipe 1: {pipe1:f2}%. Pipe 2: {pipe2:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overWater:f2} liters.");
            }
        }
    }
}
