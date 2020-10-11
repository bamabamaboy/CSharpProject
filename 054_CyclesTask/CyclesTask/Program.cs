using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример работы с динамическим массивом
            List<int> array = new List<int>();

            array.Add(-45);
            array.Add(80);
            array.Add(8564);
            array.Add(345);
            array.Add(-644);

            array.Add(-900);
            array.Add(156);
            array.Add(465);
            array.Add(701);
            array.Add(-6);


            Console.Write("Массив: ");
            foreach (int i in array) {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine("Максимальное значение: {0}", array.Max());
            Console.WriteLine("Минимальное значение: {0}", array.Min());

            array.Sort();

            Console.Write("Сортированный массив: ");
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
