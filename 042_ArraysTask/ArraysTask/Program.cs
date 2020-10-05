using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Динамический массив
            List<float> floatArray = addArray(4.5f, 545.849f, 38.56f, 78.86f, 42.65986f, 84.613f, 1.345f, 7.645f);

            printArray(floatArray);
            Console.WriteLine();

            floatArray.Sort();

            printArray(floatArray);

            Console.ReadKey();
        }

        public static List<float> addArray(params float[] fArray) {
            List<float> list = new List<float>();

            foreach (float f in fArray) {
                list.Add(f);
            }

            return list;
        }

        public static void printArray(List<float> list) {
            Console.Write("Массив: [ ");
            
            for (short i = 0; i < list.Count; i++)
            {
                Console.Write("{0}", list.ElementAt(i));

                if (i != (list.Count - 1)) 
                    Console.Write(" | ");
            }

            Console.WriteLine("]");
        }
    }
}
