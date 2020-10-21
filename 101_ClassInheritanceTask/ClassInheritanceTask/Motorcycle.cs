using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceTask {
    //Определяем класс наследник от родительского класса Vehicle
    class Motorcycle : Vehicle {

        //Дополнительные переменные наследника
        private float maxSpeed;

        //base() - вызываем конструктор родительского класса Vehicle
        public Motorcycle(float weight, float maxSpeed) 
            : base("Мотоцикл", weight) {

            this.maxSpeed = maxSpeed;
        }

        //(override - переопределяющий метод родительского класса)
        public override void printInfo() {
            Console.WriteLine("Транспорт - {0}, масса - {1} т, макс.скорость - {2} км/ч", 
                type, weight, maxSpeed);
        }



    }
}
