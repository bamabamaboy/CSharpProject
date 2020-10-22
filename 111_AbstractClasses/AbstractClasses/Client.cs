using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses {
    class Client : Person {

        public int AccountBalance { get; set; }

        public Client(string name, string secondName, int accountBalance)
            : base(name, secondName) { 
            AccountBalance = accountBalance;
        }
        //Наследник перезаписывает метод родителя
        public override void printNames() {
            Console.Write("Информация о клиенте -> ");
            base.printNames();
        }
        //Наследник реализует абстрактный метод (выполняет заложенное правило родителя)
        public override void additionalInfo() {
            Console.WriteLine("Сумма денег на счету: {0} тыс.руб.", AccountBalance);
        }

    }
}
