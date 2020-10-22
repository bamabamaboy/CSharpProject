using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses {
    //Обощенный класс (T - обобщенный тип)
    class Account<T> {
        //Переменная с обобщенным типом
        public T Id { get; set; }
        public int Balance { get; set; }

        public Account(T id, int balance) {
            Id = id;
            Balance = balance;
        }

        //Метод с обобщенным типом
        public T getId() {
            Console.WriteLine("Вызов обобщенного метода");
            return Id;
        }

    }
}
