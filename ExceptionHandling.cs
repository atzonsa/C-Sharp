using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class ExceptionHandling
    {
        public static void Main(string[] arg)
        {
            int val1 = 33;
            int val2 = 0;

            try
            {
                Console.WriteLine(val1 / val2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Write("Press an key to close");
                Console.Read();
            }
        }
    }
}