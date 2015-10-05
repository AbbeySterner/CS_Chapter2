using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int ChickenA = 5;
            int ChickenB = 14;
            int ChickenC = 9;
            int ChickenD = 12;
            int Eggs = ChickenA + ChickenB + ChickenC + ChickenD;
            int dozen = Eggs / 12;
            int eggsleft = Eggs % 12;
            Console.WriteLine(" There are {0} dozen and {1} eggs.", dozen, eggsleft);
        }
    }
}
