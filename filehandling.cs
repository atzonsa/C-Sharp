using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class FileHandling
    {
        // Main Method 
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C://what-is-c-sharp.txt");
            
                string str = "C# is a general-purpose, multi-paradigm programming language encompassing strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines.";
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();

                Console.WriteLine("File Created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }      
        } 
    }
}