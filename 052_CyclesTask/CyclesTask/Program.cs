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

            Console.Write("Введите любое число с клавиатуры: ");
            float num = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Вы ввели данное число - {0}", num);

            Console.ReadKey();
        }
    }
}
