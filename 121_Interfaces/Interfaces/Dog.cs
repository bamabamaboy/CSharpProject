using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Dog : Animal, IEat, IPlay {

        public Dog(string name)
            : base(name) {
            setType();
        }

        //Реализуем метод абстрактного класса Animal
        public override void setType() { 
            //Присваиваем переменной тип перечисления
            type = AnimalType.Dog;
            Console.WriteLine("Ваше животное - Собачка({0})! Поздравляю Вас!", type);
        }

        //Реализуем метод интерфейса IEat
        public void eat() {
            Console.WriteLine("Собачка по имени {0} кушает (Арр-Арр)", Name);
        }

        //Реализуем метод интерфейса IPlay
        public void play() {
            Console.WriteLine("Собачка по имени {0} играет с летающей тарелкой (Хвать Хвать)", Name);
        }

    }
}
