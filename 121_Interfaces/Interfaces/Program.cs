using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {

            Console.Write("Введите любое число от 1 до 3: ");
            short b = Convert.ToByte(Console.ReadLine());

            switch (b) {
                case 1:
                    Fish dori = new Fish("Дори");
                    dori.eat();
                    dori.play();
                    break;
                case 2:
                    Dog lucky = new Dog("Лаки");
                    lucky.eat();
                    lucky.play();
                    break;
                case 3:
                    Cat garfild = new Cat("Гарфилд");
                    garfild.eat();
                    garfild.play();
                    break;
            }

            Console.ReadKey();

        }
    }
}
