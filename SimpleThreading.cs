using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class SimpleThreading
    {
        static void Main(string[] arg)
        {
            Thread th1 = new Thread(Task_A);
            Thread th2 = new Thread(Task_B);

            th1.Start();
            th2.Start();
        }

        static void Task_A()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Task A No." + i.ToString());
        }

        static void Task_B()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Task B No." + i.ToString());
        }
    }
}