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
            //Пример бесконечного цикла с доп. условиями (1 - пропуск одной итерации цикла, 0 - выход из цикла)
            bool end = false;
            do
            {
                Console.Write("Введите любое число с клавиатуры: ");
                float num = Convert.ToSingle(Console.ReadLine());

                if (num == 0) end = true;

                if (end == false)
                {
                    if (num == 1) continue;
                    Console.WriteLine("One more iteration");
                }
            } while (end != true);

            Console.WriteLine("Конец!");
            Console.ReadKey();
        }
    }
}
