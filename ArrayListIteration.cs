using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Apple");
            list.Add(1000);
            list.Add(false);
            list.Add(12.12);
            list.Add(true);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}