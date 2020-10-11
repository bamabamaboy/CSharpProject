using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите значение скорости: ");
            int speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение времени: ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваша скорость: {0} км/ч, Ваше время в пути: {1} ч", speed, time);

            int way = wayCount(speed, time);
            Console.WriteLine("Рассчитанное значение: {0}", way);

            Console.ReadKey();
        }

        private static int wayCount(int speed, int time) { 
            int way = speed * time;

            Console.WriteLine("Вы проедите: {0} км", way);

            return way;
        }

    }
}
