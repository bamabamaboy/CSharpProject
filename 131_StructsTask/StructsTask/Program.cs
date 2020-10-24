using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsTask {
    class Program {
        static void Main(string[] args) {

            //Структуры не обязательно инициализировать с помощью new...
            Computer myComp;

            //но обязательно инициализировать все переменные перед использованием
            myComp.processor = "Core i7";
            myComp.weight = 2.3f;
            myComp.workingTime = 7;
            myComp.yadra = 4;
            myComp.os = "Windows 10";

            //Как то используем параметры из инициализированной структуры
            Console.WriteLine(myComp.processor);

            Console.ReadKey();
        }
    }
}
