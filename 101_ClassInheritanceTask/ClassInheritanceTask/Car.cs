using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceTask {
    //Определяем класс наследник от родительского класса Vehicle
    class Car : Vehicle {

        //Дополнительные переменные наследника
        private string color;
        private string model;
        private short numPeoples;

        //base() - вызываем конструктор родительского класса Vehicle
        public Car(float weight, string color, string model, short numPeoples) 
            : base("Автомобиль", weight) {

            this.color = color;
            this.model = model;
            this.numPeoples = numPeoples;
        }

        //(override - переопределяющий метод родительского класса)
        public override void printInfo() {
            Console.WriteLine("Транспорт - {0}, масса - {1} т, модель - {2}, кол-во человек - {3}", 
                type, weight, model, numPeoples);
        }

    }
}
