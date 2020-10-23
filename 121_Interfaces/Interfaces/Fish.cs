using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Fish : Animal, IEat, IPlay {

        public Fish(string name) : base(name) {
            setType();
        }

        //Реализуем метод абстрактного класса Animal
        public override void setType() { 
            //Присваиваем переменной тип перечисления
            type = AnimalType.Fish;
            Console.WriteLine("Ваше животное - Рыбка({0})! Поздравляю Вас!", type);
        }

        //Реализуем метод интерфейса IEat
        public void eat() {
            Console.WriteLine("Рыбка по имени {0} кушает (Бульк-Бульк)", Name);
        }

        //Реализуем метод интерфейса IPlay
        public void play() {
            Console.WriteLine("Рыбка по имени {0} играет с пузырьками (Буль Буль Буль)", Name);
        }

    }
}
