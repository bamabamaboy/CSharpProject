using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;             //Подключаем библиотеку для работы с классом Thread
using System.Threading.Tasks;

namespace ThreadsTask {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("------------------------------------------------------------");
            //Получим всю информацию вначале о главном потоке
            Thread threadMain = Thread.CurrentThread;           //Инициализируем ссылку объектом основного потока
            threadMain.Name = "Основной поток";                 //Дадим имя основному потоку

            //Выведем в консоль информацию об основном потоке
            Console.WriteLine("Имя потока: {0}", threadMain.Name);
            Console.WriteLine("Приоритет потока: {0}", threadMain.Priority);
            Console.WriteLine("Статус потока: {0}", threadMain.ThreadState);
            Console.WriteLine("Запущен ли поток: {0}", threadMain.IsAlive);

            Console.WriteLine("Домен приложения: {0}", Thread.GetDomain().FriendlyName);

            Console.WriteLine("------------------------------------------------------------");

            //Включаем первый отдельный поток
            treadOneON();

            //Включаем второй отдельный поток
            treadTwoON();

            //Запуска код для основного потока программы
            treadMainON();

            Console.ReadKey();
        }

        private static void treadMainON() {
            //Код для основного потока
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("--> Главный поток данных.");
                Thread.Sleep(0);
            }
        }

        private static void treadOneON() {
            //Организуем первый отдельный поток
            Thread t1 = new Thread(new ThreadStart(treadOne));
            t1.Start();
        }

        private static void treadTwoON() {
            //Организуем второй отдельный поток
            Thread t2 = new Thread(new ThreadStart(treadTwo));
            t2.Start();
        }

        private static void treadOne() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("----> Поток TreadOne под номером: {0}", i);
                Thread.Sleep(0);
            } 
        }

        private static void treadTwo() {
            for (int i = 0; i < 7; i++) {
                Console.WriteLine("------> Поток TreadTwo под номером: {0}", i);
                Thread.Sleep(0);
            }
        }

    }
}
