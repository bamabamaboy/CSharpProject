using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Задание 1:");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Введите первое число: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите второе число: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ваши числа: " + num1 + " и " + num2);

            //Пример использования тернарного оператора
            float result = (num2 != 0) ? (num1 / num2) : 1;
 
            Console.WriteLine("Результат деления чисел: {0}", result);
            Console.WriteLine("----------------------------------------------");

            Console.ReadKey();
        }
    }
}
