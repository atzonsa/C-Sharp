using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class ObjectReference
    {
        public static void Main(string[] arg)
        {
            string str = "ssssssssss";
            char c = Char.Parse("s");
            String str1 = new String(c, 10);
            String str2 = new String(c, 10);

            Console.WriteLine("str: " + str);
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);

            Console.WriteLine((str == str1) ? "equal" : "not equal");
            Console.WriteLine((str1 == str2) ? "equal" : "not equal");
            Console.WriteLine((str2 == str) ? "equal" : "not equal");

            Console.WriteLine("Press any key to close");
            Console.Read();
        }
    }
}
