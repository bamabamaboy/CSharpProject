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
            Console.WriteLine("Добро пожаловать в Консольный калькулятор!");
            printLine();

            mainCycle();
        }

        //Основной цикл калькулятора
        private static void mainCycle() {
            bool end;

            do
            {

                Console.Write("Введите первое число: ");
                float num1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Введите второе число: ");
                float num2 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Введите действие из списка возможных (\"+\", \"-\", \"*\", \"/\", \"%\"): ");
                string action = Console.ReadLine();
                printLine();

                calculate(num1, num2, action);
                printLine();

                additionalCycle(out end);

            } while (!end);
        }

        //Доп. цикл калькулятора, проверка ответа для закрытия программы
        private static void additionalCycle(out bool end) {
            bool check = false;
            end = false;

            do
            {
                Console.Write("Хотите что-нибудь ещё посчитаем?(\"да\", \"нет\") ");
                string answer = Console.ReadLine();

                if (answer.ToLower().Contains("нет"))
                {
                    check = true;
                    end = true;
                }
                else if (answer.ToLower().Contains("да"))
                {
                    check = true;
                    end = false;
                }

                printLine();

            } while (!check);
        }

        //Сам калькулятор
        private static void calculate(float x, float y, string action) {

            float result;

            switch (action) {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    if (y != 0) {
                        result = x / y;
                    } else {
                        Console.WriteLine("Делитель не должен быть равен нулю!");
                        return;
                    }
                    break;
                case "%":
                    result = x % y;
                    break;
                default:
                    Console.WriteLine("Калькулятор не поддерживает введённое действие!");
                    return;
            }

            Console.WriteLine("{0} {1} {2} = {3}", x, action, y, result);
        }

        //Метод рисует линию
        private static void printLine() {
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
