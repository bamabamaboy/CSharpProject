using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House();
            house1.Year = -16;                                      //Вызов свойства set (с проверкой на значение года)
            house1.Address = new Address("Сочи", "ул. Олимпийская деревня", "24 кр.8");

            House house2 = new House("Новенький жилой Домик", 2020);

            House house3 = new House("Местный Кремль", 25, 1602);
            house3.Address = new Address("Москва", "ул. Самая Красная Площадь", "1 кр.1");

            Address addressHouse4 = new Address();
            addressHouse4.setAddress("Ольгинка", "ул. Советская", "99");
            House house4 = new House("Дом Аллигарха", 75, 2018, addressHouse4);

            Console.WriteLine("Кол-во построек всего: {0}", House.houseCount);

            Console.WriteLine("---------------------------------");
            house1.printAllInfo();
            Console.WriteLine("---------------------------------");
            house2.printAllInfo();
            Console.WriteLine("---------------------------------");
            house3.printAllInfo();
            Console.WriteLine("---------------------------------");
            house4.printAllInfo();
            Console.WriteLine("---------------------------------");

            Console.ReadKey();
        }
    }
}
