using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
             double length=10;
            double width=20;
            double area=length*width;
            double price=1.20;
            double cost=area*price;
            Console.WriteLine("The Carpet will cost ${0}", cost);
        
        
        }
    }
}
