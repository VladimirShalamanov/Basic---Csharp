using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGroups = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            

            for (int i = 1; i <= numGroups; i++)
            {
                int numPeoplesInGroupe = int.Parse(Console.ReadLine());

                if (numPeoplesInGroupe <= 5)
                {
                    musala += numPeoplesInGroupe;
                }
                else if (6 <= numPeoplesInGroupe && numPeoplesInGroupe <= 12)
                {
                    monblan += numPeoplesInGroupe;
                }
                else if (13 <= numPeoplesInGroupe && numPeoplesInGroupe <= 25)
                {
                    kilimandjaro += numPeoplesInGroupe;
                }
                else if (26 <= numPeoplesInGroupe && numPeoplesInGroupe <= 40)
                {
                    k2 += numPeoplesInGroupe;
                }
                else if (41 <= numPeoplesInGroupe)
                {
                    everest += numPeoplesInGroupe;
                }


            }

            double allPeoples = musala + monblan + kilimandjaro + k2 + everest;
            double percentege1 = (musala / allPeoples) * 100;
            double percentege2 = (monblan / allPeoples) * 100;
            double percentege3 = (kilimandjaro / allPeoples) * 100;
            double percentege4 = (k2 / allPeoples) * 100;
            double percentege5 = (everest / allPeoples) * 100;

            Console.WriteLine($"{percentege1:f2}%");
            Console.WriteLine($"{percentege2:f2}%");
            Console.WriteLine($"{percentege3:f2}%");
            Console.WriteLine($"{percentege4:f2}%");
            Console.WriteLine($"{percentege5:f2}%");
        }
    }
}
