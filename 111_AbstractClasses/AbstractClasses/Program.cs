using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses {
    class Program {
        static void Main(string[] args) {

            //Пример инициализации наследниками абстрактного класса
            Person employee = new Employee("Иван", "Ивановский", "Менеджер банка");
            Person client = new Client("Дмитрий", "Первый", 785);

            Console.WriteLine("----------------------------------");
            employee.printNames();
            employee.additionalInfo();

            Console.WriteLine("----------------------------------");
            client.printNames();
            client.additionalInfo();

            //Создаем объекты обобщенного класса
            Account<string> stringId = new Account<string>("id455", 854);
            string id1 = stringId.getId();

            Account<int> intId = new Account<int>(455, 854);
            int id2 = intId.getId();

            Console.ReadKey();
        
        }
    }
}
