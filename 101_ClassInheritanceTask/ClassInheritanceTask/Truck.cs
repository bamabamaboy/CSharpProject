using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceTask {
    //Определяем класс наследник от родительского класса Vehicle
    class Truck : Vehicle {

        //Дополнительные переменные наследника
        private int numWheels;
        private float maxCarrying;

        //base() - вызываем конструктор родительского класса Vehicle
        public Truck(float weight, int numWheels, float maxCarrying)
            : base("Грузовик", weight) {
            
            this.numWheels = numWheels;
            this.maxCarrying = maxCarrying;
        }

        //(override - переопределяющий метод родительского класса)
        public override void printInfo() {
            Console.WriteLine("Транспорт - {0}, масса - {1} т, кол-во колёс - {2} шт., макс.грузоподъемность - {3} т", 
                type, weight, numWheels, maxCarrying);
        }

    }
}
