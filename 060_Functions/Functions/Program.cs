using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 1, 3, 45, 110, 501, 63, 84, 64, 80 };
            int[] digits2 = { 5, 8, 4, 2, 15, 18, 11, 18, 15 };

            short[] digitsShort = { 1, 2, 3, 4, 5 };
            short[] digitsShort2 = { 5, 4, 3, 2, 1 };

            Console.WriteLine("---------------------------------------");
            PrintArray("", ref digits);

            int max = 0;
            MaxElement(digits, out max);
            Console.WriteLine("Максимальное число = {0}", max);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Перенос значений из одного массива (int[]) в другой:");
            PrintArray("digits", ref digits);
            PrintArray("digits2", ref digits2);

            ChangeArrays(ref digits, ref digits2);

            PrintArray("digits", ref digits);
            PrintArray("digits2", ref digits2);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Перенос значений из одного массива (short[]) в другой:");

            PrintArray("digitsShort", ref digitsShort);
            PrintArray("digitsShort2", ref digitsShort2);

            ChangeArrays(ref digitsShort, ref digitsShort2);

            PrintArray("digitsShort", ref digitsShort);
            PrintArray("digitsShort2", ref digitsShort2);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Метод принимает любые типы параметров:");
            Console.WriteLine("Для - int[]:");
            PrintAnyArray<int>("", ref digits);

            Console.WriteLine("Для - short[]:");
            PrintAnyArray<short>("", ref digitsShort);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Метод с переменным кол-вом параметров:");
            SumAll(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Коллекция, которая принимание любые типы данных:");
            
            ArrayList al = new ArrayList();
            al.Add("Привет Мир!");
            al.Add(1);
            al.Add(4.845f);
            al.Add('R');

            foreach (object i in al) {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Пример словаря:");

            Dictionary<string, char> d = new Dictionary<string, char>();
            d.Add("usa", 'U');
            d.Add("russia", 'R');
            d.Add("england", 'E');

            char value;
            d.TryGetValue("usa", out value);

            Console.WriteLine(value);

            foreach (KeyValuePair<string, char> i in d) {
                Console.WriteLine("Ключ: {0}, Значение: {1}", i.Key, i.Value);
            }

            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
        
        //out - проброс переменной внутрь метода, где происходит работа с внешней переменной
        public static void MaxElement(int[] numbers, out int max) {
            max = numbers[0];

            foreach (int i in numbers) {
                if (max < i) max = i; 
            }
        }

        //Использование в методе ссылок на объекты (reference - указатель, ссылка)
        //Работает только тогда, когда оба массива одной длинны
        public static void ChangeArrays(ref int[] a, ref int[] b) {
            int[] temp = new int[a.Length];

            a.CopyTo(temp, 0);
            Array.Clear(a, 0, a.Length);

            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);

            temp.CopyTo(b, 0);

        }

        //Перегрузка функции
        public static void ChangeArrays(ref short[] a, ref short[] b) {
            short[] temp = new short[a.Length];

            a.CopyTo(temp, 0);
            Array.Clear(a, 0, a.Length);

            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);

            temp.CopyTo(b, 0);
        }

        //Метод принимает любые типы параметров
        public static void ChangeArrays<T>(ref T[] a, ref T[] b)
        {
            T[] temp = new T[a.Length];

            a.CopyTo(temp, 0);
            Array.Clear(a, 0, a.Length);

            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);

            temp.CopyTo(b, 0);
        }

        public static void PrintArray(String nameArray, ref int[] array) {
            Console.Write("Массив {0}: ", nameArray);
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        //Перегрузка функции
        public static void PrintArray(String nameArray, ref short[] array) {
            Console.Write("Массив {0}: ", nameArray);
            foreach (short i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        //Метод принимает любые типы параметров
        public static void PrintAnyArray<T>(String nameArray, ref T[] array)
        {
            Console.Write("Массив {0}: ", nameArray);
            foreach (T i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        //Метод с переменным кол-вом параметров
        public static void SumAll(params int[] numbers) {
            int sum = 0;

            foreach (int i in numbers) {
                sum += i;
            }

            Console.WriteLine("Общая сумма чисел = {0}", sum);
        }


    }
}
