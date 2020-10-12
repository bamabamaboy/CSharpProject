using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"Start Text.txt";
            string text1 = "В одной далёкой, далёкой галактике...Жили были Джедаи...";

            string file2 = @"Centr Text.txt";
            string text2 = "Победил Люк Скайокер...";

            string file3 = @"End Text.txt";
            string text3 = "И воцарился мир в далёкой галактике...";
            
            //Примеры работы с файлами:
            //Пример работы с файлами через класс File (без потока данных)
            simpleFile(file1, text1);

            //Пример работы с файлами через потоки данных (запись и чтение осинхронно) (но много кода)
            dataStreams(file2, text2);

            //Самые главные классы для работы с файлами
            mainStreams(file3, text3);

            Console.ReadKey();

        }

        private static void mainStreams(string fileName, string text) {
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(text);

            sw.Close();

            StreamReader sr = File.OpenText(fileName);
            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
        }

        private static void dataStreams(string fileName, string text)
        {
            //Запись из потока данных
            FileStream fs = File.Open(fileName, FileMode.Create);
            byte[] writeStrByte = Encoding.Default.GetBytes(text);

            fs.Write(writeStrByte, 0, writeStrByte.Length);

            //Чтение из потока данных
            fs.Position = 0;    //Возвращаем на нулевую позицию в файле

            byte[] readStrByte = new byte[writeStrByte.Length];

            for (int i = 0; i < writeStrByte.Length; i++)
            {
                readStrByte[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(readStrByte));

            fs.Close();     //После всех операций с файлом, его необходимо закрыть
        }

        private static void simpleFile(string fileName, string text)
        {
            //Пример работы с файлами через класс File (без потока данных)
            //Запись в файл
            File.WriteAllText(fileName, text);

            //Чтение из файла
            foreach (string line in File.ReadAllLines(fileName))
            {
                Console.WriteLine(text);
            }
        }

    }
}
