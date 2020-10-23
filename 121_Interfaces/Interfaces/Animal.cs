using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    //Абстрактный класс, в отличие от интерфейса, заключает в себе правило (про какие методы нужно не забыть, и их может быть много)
    //А интерфейс - это обязательство реализации методов в другом классе (и чаще всего таких методов не много)
    //(Интерфейсы добовляют доп.функционал к основному классу, а абстрактные классы - это основной функционал наследника)
    abstract class Animal {
        
        protected AnimalType type;
        public string Name { get; set; }

        public Animal(string name) {
            Name = name;
        }

        public abstract void setType();

    }
}
