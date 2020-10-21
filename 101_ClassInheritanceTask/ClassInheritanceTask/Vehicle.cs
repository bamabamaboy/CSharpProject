using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceTask {
    //Родительский класс Vehicle
    class Vehicle {
        
        //Переменные родительского класса Vehicle 
        //(protected - чтобы были доступны наследникам)
        protected string type;
        protected float weight;

        public Vehicle(string type, float weight) {
            this.type = type;
            this.weight = weight;
        }

        //Основной метод
        //(virtual - можно переопределять наследникам)
        public virtual void printInfo() {
            Console.WriteLine("Транспорт - {0}, масса - {1} т", type, weight);
        }


    }
}
