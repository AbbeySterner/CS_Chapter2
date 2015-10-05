using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            double length=25;
            double width = 42;
            double area = length * width;
            double areainyards = area / 9;
            double price = 1.25;
            double cost = areainyards * price;
            Console.WriteLine("The cost of the carpet is {0}", cost.ToString("C")); 
        }
    }
}
