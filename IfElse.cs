using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class IfElse
    {
        static void Main(string[] arg)
        {
            while (true)
            {
                Console.WriteLine("Please enter value from below options");
                Console.WriteLine("10, 20, 30, 40, 50");

                int val = 0;
                Int32.TryParse(Console.ReadLine(), out val);

                if (val == 10)
                    Console.WriteLine("Ten");
                else if (val == 20)
                    Console.WriteLine("Twenty");
                else if (val == 30)
                    Console.WriteLine("Thirty");
                else if (val == 40)
                    Console.WriteLine("Fourty");
                else if (val == 50)
                    Console.WriteLine("Fifty");
                else
                    Console.WriteLine("Invalid value");
            }
        }
    }
}
