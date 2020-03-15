using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class ArraySorting
    {
        public static void Main(string[] arg)
        {
            string[] arr = {"dddd", "eeee", "aaaaa", "nnnn", "vvvv"};
            
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("---------------------------------------------------------------");

            arr = new string[] { "dddd", "eeee", "aaaaa", "nnnn", "vvvv" };

            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("---------------------------------------------------------------");

            int[] arrInt = { 80, 50, 65, 4, 0, 2, 100 };

            arrInt = arrInt.OrderBy(c => c).ToArray();

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }

            Console.WriteLine("---------------------------------------------------------------");

            arrInt = new int[] { 80, 50, 65, 4, 0, 2, 100 };

            arrInt = arrInt.OrderByDescending(c => c).ToArray();

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }

            Console.WriteLine("---------------------------------------------------------------");

            arrInt = new int[] { 80, 50, 65, 4, 0, 2, 100 };

            Array.Sort<int>(arrInt, new Comparison<int>(
                  (i1, i2) => i1.CompareTo(i2)));

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }

            Console.WriteLine("---------------------------------------------------------------");

            arrInt = new int[] { 80, 50, 65, 4, 0, 2, 100 };

            Array.Sort<int>(arrInt, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("Press any key to close");
            Console.Read();
        }
    }
}
