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
            //Пример работы с двумерным массивом
            short[,] array = { 
                     {0, 34, -2},
                     {3, -4, 5},
                     {10, 81, 45},
                     {-17, -16, -99},
                     {845, 14, 245}
            };

            printTotalInfo(array);

            Console.ReadKey();
        }

        private static void printTotalInfo(short[,] array)
        {
            printLine();
            printArray(array);
            printLine();
            getCountArray(array);
            getSumArray(array);
            getSubtArray(array);
            getMaxArray(array);
            getMinArray(array);
            getAverageArray(array);
            printLine();
        }

        private static void printArray(short[,] array) {
            Console.WriteLine("Массив:");
            Console.WriteLine();
            for (short i = 0; i < (array.GetUpperBound(0) + 1); i++)
            {
                Console.Write("\t");
                for (short j = 0; j < (array.Length / (array.GetUpperBound(0) + 1)); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void getCountArray(short[,] array)
        {
            short count = 0;
            for (short i = 0; i < (array.GetUpperBound(0) + 1); i++)
            {
                for (short j = 0; j < (array.Length / (array.GetUpperBound(0) + 1)); j++)
                {
                    count++;
                }
            }
            Console.WriteLine("Кол-во чисел в Массиве:\t\t{0}", count);
        }

        private static void getSumArray(short[,] array)
        {
            short sum = 0;
            for (short i = 0; i < (array.GetUpperBound(0) + 1); i++)
            {
                for (short j = 0; j < (array.Length / (array.GetUpperBound(0) + 1)); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Сумма чисел в Массиве:\t\t{0}", sum);

        }

        private static void getSubtArray(short[,] array)
        {
            short subt = 0;
            for (short i = 0; i < (array.GetUpperBound(0) + 1); i++)
            {
                for (short j = 0; j < (array.Length / (array.GetUpperBound(0) + 1)); j++)
                {
                    subt -= array[i, j];
                }
            }
            Console.WriteLine("Разность чисел в Массиве:\t{0}", subt);
        }

        private static void getMaxArray(short[,] array)
        {
            short max = 0;
            for (short i = 0; i < (array.GetUpperBound(0) + 1); i++)
            {
                for (short j = 0; j < (array.Length / (array.GetUpperBound(0) + 1)); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            Console.WriteLine("Максимальное число в Массиве:\t{0}", max);
        }

        private static void getMinArray(short[,] array)
        {
            short min = 0;
            for (short i = 0; i < (array.GetUpperBound(0) + 1); i++)
            {
                for (short j = 0; j < (array.Length / (array.GetUpperBound(0) + 1)); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            Console.WriteLine("Минимальное число в Массиве:\t{0}", min);
        }

        private static void getAverageArray(short[,] array)
        {
            float average = 0;
            float x = 0;
            for (short i = 0; i < (array.GetUpperBound(0) + 1); i++)
            {
                for (short j = 0; j < (array.Length / (array.GetUpperBound(0) + 1)); j++)
                {
                    x++;
                    average += array[i, j];
                }
            }
            average /= x;
            Console.WriteLine("Среднее число Массива:\t\t{0}", average);
        }

        private static void printLine() {
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
