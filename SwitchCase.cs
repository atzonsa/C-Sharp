using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class SwitchCase
    {
        static void Main(string[] arg)
        {
            while (true)
            {
                Console.WriteLine("Please enter value from below options");
                Console.WriteLine("10, 20, 30, 40, 50");
                
                int val = 0;
                Int32.TryParse(Console.ReadLine(), out val);

                switch (val)
                {
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 20:
                        Console.WriteLine("Twenty");
                        break;
                    case 30:
                        Console.WriteLine("Thirty");
                        break;
                    case 40:
                        Console.WriteLine("Fourty");
                        break;
                    case 50:
                        Console.WriteLine("Fifty");
                        break;
                    default:
                        Console.WriteLine("Invalid value");
                        break;
                }
            }
        }
    }
}
