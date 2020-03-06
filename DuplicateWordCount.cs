using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class DuplicateWordCount
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Please enter the path...");
            string path = Console.ReadLine();
            Console.WriteLine("Please enter the word to find...");
            string word = Console.ReadLine();

            //char[] abc = {char.Parse(" ")};

            string str = "";
            StreamReader sr = new StreamReader(path);
            using (sr)
            {
                str = sr.ReadToEnd();
            }

            Console.WriteLine(str);

            string[] arr = str.Split(new char[] {char.Parse(" ")}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(arr.ToString());

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                
                if (arr[i].Trim() == word)
                    count++;
            }

            Console.WriteLine("Word \"" + word + "\" came " + count + " number of times.");

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}