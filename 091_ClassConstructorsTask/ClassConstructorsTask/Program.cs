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
            House myHouse = new House("Жилой Дом", 14, 1972);

            myHouse.setAddress("Москва", "ул. Халтуринская", "12 кр.1");

            myHouse.printAllInfo();

            Console.ReadKey();
        }
    }
}
