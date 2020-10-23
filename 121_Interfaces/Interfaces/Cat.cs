using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Cat : Animal, IEat, IPlay {

        public Cat(string name)
            : base(name) {
            setType();
        }

        //Реализуем метод абстрактного класса Animal
        public override void setType() { 
            //Присваиваем переменной тип перечисления
            type = AnimalType.Cat;
            Console.WriteLine("Ваше животное - Кошечка({0})! Поздравляю Вас!", type);
        }

        //Реализуем метод интерфейса IEat
        public void eat() {
            Console.WriteLine("Кошечка по имени {0} кушает (Мурк-Мур)", Name);
        }

        //Реализуем метод интерфейса IPlay
        public void play() {
            Console.WriteLine("Кошечка по имени {0} играет с маленьким мячиком (Нямк Ням)", Name);
        }


    }
}
