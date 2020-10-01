using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------");
            int number;

            number = 5;
            Console.WriteLine("Variable = " + number);

            number = 10;
            Console.WriteLine("Variable = " + number);
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.Write("Введи кол-во полных лет: ");
            byte age = Convert.ToByte(Console.ReadLine(), 10);

            Console.WriteLine("Здравствуйте! Ваше имя - " + name + ", и Вам полных - " + age + " лет!");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");
            Console.Write("Введите первое число: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
            
            Console.WriteLine("----------------------------------------------");
            Console.ReadKey();
        }
    }
}
