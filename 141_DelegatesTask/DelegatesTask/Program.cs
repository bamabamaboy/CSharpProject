using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTask {
    class Program {

        //Определяем (объявленяем) новый делегат
        delegate void Message();

        delegate void MessageWithText(string text);

        delegate int Operatin(int x, int y);
        
        static void Main(string[] args) {

            //Примеры функционала делегата - обозначены в комментариях знаком >>>

            Console.WriteLine("----------------------------------------------------------");
            //>>> Функционал делегата - указатель на другой метод
            
            //Создаём переменную созданного делегата
            Message message;

            if (DateTime.Now.Hour < 10) {
                message = textHello;
            } else {
                message = textByeBye;
            }

            //Выполнение метода из списка вызовов делегата
            message();


            Console.WriteLine("----------------------------------------------------------");
            //>>> Функционал делегата - делигирование классом выполнения некоторого кода извне

            //(Определяем дополнительную логику извне для выполнение какого-то дейтсвия внутри другого класса)
            Account myAccount = new Account(400);
            Account.AccountStateHandler colorDelegat = new Account.AccountStateHandler(colorMessage);

            //Для первого метода в списке делегат передаём объект, в котором инициализируем переменую делегата 
            myAccount.registerHandler(new Account.AccountStateHandler(showMessage));

            //>>> Функционал делегата - добавление, удаление и поочередное выполнение нескольких методов в списке делегатов

            //В методе registerHandler() добавляем метод список вызовов делегата
            myAccount.registerHandler(colorDelegat);
            myAccount.withdraw(200);
            myAccount.withdraw(100);

            //В методе unregisterHandler() удаляем метод из списка вызовов делегата
            myAccount.unregisterHandler(colorDelegat);
            myAccount.withdraw(250);
            
            Console.WriteLine("----------------------------------------------------------");
            //>>> Функционал делегата - выполнение анонимных методов, которые позволяют создавать готовые экземрляры готов делегатов
            //(Объявление анонимного метода начинается с delegate())
            MessageWithText messageWithText = delegate(string text) {
                Console.WriteLine(text);
            };

            messageWithText("Зупуск анонимный метод!");

            Console.WriteLine("----------------------------------------------------------");
            //>>> Функционал делегата - использование с лямбда-выражениями, которые являются упрощённой запись анонимных методов

            Operatin operation = (x, y) => x * y;   //Лямбда-выражение для опеределение операции умножение двух чисел
            Console.WriteLine("Результат умножение двух чисел - {0}", operation(10, 2));

            //Интересно - если мы доабвим в список выполнения доп.метод, то результат операций выведетя только для последнего метода
            operation += (x, y) => x + y;           //Лямбда-выражение для опеределения операции сложения двух чисел
            Console.WriteLine("В списке выполенения делегата несколько методов, но результат только последнего, это сложение - {0}", operation(153, 47));

            Console.WriteLine("----------------------------------------------------------");

            Console.ReadKey();
        }

        //Метод - вывод текст в консоль "Привет"
        private static void textHello() {
            Console.WriteLine("Привет Привет!");
        }

        //Метод - вывод текст в консоль "Пока"
        private static void textByeBye() {
            Console.WriteLine("Пока Пока!");
        }

        //Метод - нужного сообщения в консоль
        private static void showMessage(string message) {
            Console.WriteLine(message);
        }

        //Метод - смена цвета текста в консоли
        private static void colorMessage(string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);

            Console.ResetColor();
        }

    }
}
