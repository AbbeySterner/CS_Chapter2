using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            int ChickenA, ChickenB, ChickenC, ChickenD;
            Console.WriteLine("Enter a number of eggs...");
            ChickenA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of eggs...");
            ChickenB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of eggs...");
            ChickenC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of eggs...");
            ChickenD = Convert.ToInt32(Console.ReadLine());

            int Eggs = ChickenA + ChickenB + ChickenC + ChickenD;
            int dozen = Eggs / 12;
            int eggsleft = Eggs % 12;
            Console.WriteLine(" There are {0} dozen and {1} eggs.", dozen, eggsleft);

        }
    }
}
