using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceTask {
    class Program {
        static void Main(string[] args) {

            List<Vehicle> myTransport = new List<Vehicle>();

            //Ссылка родительского класса указывает объект наследника
            Vehicle v1 = new Car(1.5f, "Красный", "BMW", 5);
            myTransport.Add(v1);

            Vehicle v2 = new Motorcycle(0.5f, 250);
            myTransport.Add(v2);

            Vehicle v3 = new Truck(8.3f, 12, 5.23f);
            myTransport.Add(v3);

            //Выведем информацию про каждое транспртное средство,
            //вызвав метод родительского класса (ООП-принцип "Полиморфизм" - в действие)
            foreach (Vehicle v in myTransport) {
                v.printInfo();
            }

            Console.ReadKey();
        }
    }
}
