using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTask {
    class Account {

        int sum;

        //Определяем (объявленяем) делегат
        //(Создаём делегат, определяя возвращаемый тип и принимаемые аргументы)
        public delegate void AccountStateHandler(string message);

        //Создаём переменную созданного делегата
        AccountStateHandler delegat;

        public Account(int sum) {
            this.sum = sum;
        }

        public int currentSum { 
            get {
                return sum;
            }
        }

        public void put(int sum) {
            this.sum += sum;
        }

        public void withdrawWithoutNotice(int sum) { 
            if (sum <= this.sum) {
                this.sum -= sum;
            }
        }

        //При снятие денег, делигируем функционал уведомления о снятие на усмотрение разрабочиков программы извне
        //Если в список вызовов делегата будет добавлен метод, то при вызове метода withhdraw() будет вызываться выполнение делегата
        //Так как разработчики класса не знают, куда требуется выводить уведомление, то этот функционал остаётся на усмотрение разработчиков извне
        //(Выводить в консоль, отраправка сообщения по email или SMS-кой на телефон, или текстом в окно приложения и т.п.)
        public void withdraw(int sum) {
            if (sum <= this.sum) {
                this.sum -= sum;

                if (this.delegat != null) {
                    this.delegat("Сумма " + sum + " снята со счета");
                }
            } else {
                if (this.delegat != null) {
                    this.delegat("Недостаточно денег на счете!");
                }
            }
        }

        //Метод добавляет доп.метод в список вызовов делегата
        public void registerHandler(AccountStateHandler delegat) {
            this.delegat += delegat;
        }

        //Метод убирает доп.метод из списка вызовов делегата
        //(и если есть несколько одинаковых методов, то убирает с конца)
        public void unregisterHandler(AccountStateHandler delegat) {
            this.delegat -= delegat;
        }

    }
}
