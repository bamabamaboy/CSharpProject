using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sh = -34;
            string s = "Hello";
            char c = 'R';
            float f = 23.093433222f;
            short i = 30000;
            bool b = true;
            byte by = 0;

            string t = "\t";
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("sbyte" + t + " = " + sh);
            Console.WriteLine("string" + t + " = " + s);
            Console.WriteLine("char" + t + " = " + c);
            Console.WriteLine("float" + t + " = " + f);
            Console.WriteLine("short" + t + " = " + i);
            Console.WriteLine("bool" + t + " = " + b);
            Console.WriteLine("byte" + t + " = " + by);
            Console.WriteLine("---------------------------------------");

            Console.ReadKey();
        }
    }
}
