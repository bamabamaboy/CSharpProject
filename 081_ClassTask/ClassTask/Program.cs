using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример создания объектов класса Car
            List<Car> garage = new List<Car>();
            
            //Авто 1
            Car car = new Car();
            car.setAllInfo("Ауди ТТ", 1600, "Чёрная", 240);
            garage.Add(car);

            //Авто 2
            car = new Car();
            car.setAllInfo("Ферари", 1900, "Красная", 280);
            garage.Add(car);

            //Авто 3
            car = new Car();
            car.setAllInfo("Ламборгини", 2100, "Жёлтая", 310);
            garage.Add(car);

            //Вывод информации о всех Авто в гараже
            byte i = 0;
            foreach (Car c in garage){
                i++;
                Console.WriteLine("----------- Машина в гараже №{0} -----------", i);
                c.getCarInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
