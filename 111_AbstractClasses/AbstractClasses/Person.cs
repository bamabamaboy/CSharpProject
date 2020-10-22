using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses {
    //Абстрактный класс - является правилом для наследников в реализации нужных методов
    //(Абстрактный класс содержит методы, которые необходимо реализвать наследникам)
    abstract class Person {

        public string Name { get; set; }
        public string SecondName { get; set; }

        public Person(string name, string secondName) { 
            Name = name;
            SecondName = secondName;
        }
        //Основной метод родителя, который можно перезаписать (virtual)
        public virtual void printNames() {
            Console.WriteLine("Имя: {0}, Фамилия: {1}", Name, SecondName);
        }

        //Абстрактный метод(без тела), который должны реализовывать наследники (abstract)
        public abstract void additionalInfo();

    }
}
