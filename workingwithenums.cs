using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class WorkingWithEnums
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Following are the titles:");

            foreach (Months mon in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(mon);
            }

            Console.WriteLine("");

            Console.WriteLine("Following are the values:");

            foreach (int mon in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(mon);
            }
        } 
    }

    enum Months 
    { 
        JANUARY = 1, 
        FEBURARY = 2, 
        MARCH = 3,
        APRIL = 4, 
        MAY = 5,
        JUNE = 6,
        JULY = 7,
        AUGUST = 8,
        SEPTEMBER = 9,
        OCTOBER = 10,
        NOVEMBER = 11,
        DECEMBER = 12
    } 
}