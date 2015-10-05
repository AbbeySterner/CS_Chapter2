using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 150;
            int hours=150/60;
            int minutesleft = minutes % 60;
            Console.WriteLine("There are {0} hours and {1} minutes.", hours, minutesleft); 

        }
    }
}
