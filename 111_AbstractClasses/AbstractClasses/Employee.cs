using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses {
    class Employee : Person {

        public string Function { get; set; }

        public Employee(string name, string secondName, string function) 
            : base(name, secondName) {
            Function = function;
        }
        //Наследник перезаписывает метод родителя
        public override void printNames() {
            Console.Write("Информация о сотруднике -> ");
            base.printNames();
        }
        //Наследник реализует абстрактный метод (выполняет заложенное правило родителя)
        public override void additionalInfo() {
            Console.WriteLine("Должность сотрудника: {0}", Function);
        }

    }
}
