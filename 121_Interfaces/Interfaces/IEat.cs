using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    //Интерфейс, в котором описано, какие методы необходимо реализовать(Инструкция для других классов)
    //Наследование может быть только от одного класса, а интерфейсов может быть много
    interface IEat {
        //Методы записываются без модификаторов доступа (всегда public)
        void eat();

    }
}
