using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    public class MultipleConstructorTest
    {
        public static void Main(string[] args)
        {
            MultiConstructor obj1 = new MultiConstructor();
            MultiConstructor obj2 = new MultiConstructor(15);
            obj1.plus();
            obj2.plus();
            obj2.minus();
            Console.WriteLine(obj1.age);
            Console.WriteLine(obj2.age);
        } 
    }

    public class MultiConstructor
    {
        public int age = 10;

        public MultiConstructor()
        {

        }

        public MultiConstructor(int value)
        {
            this.age = value;
        }

        public void plus()
        {
            this.age++;
        }

        public void minus()
        {
            this.age--;
        }
    }
}
