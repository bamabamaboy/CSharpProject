using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTask {
    [Serializable]
    public class People {       //Для Сериализации, должен быть public

        public string name;
        public int age;
        
        //Все поля, которые имеют модификатор доступ private, не будут сериализованы в формате XML
        private string surname;
        
        //[NonSerialized]             //Это не работает при сериализации в формате XML
        private string body;

        //Для сериализации объекта в формате XML, то у класса должен быть пустой конструктор
        public People() {

        }

        public People(string name, int age, string surname, string body) {
            this.name = name;
            this.age = age;
            this.surname = surname;
            this.body = body;
        }

        public void printInfo() {
            Console.WriteLine("Имя человека: {0}, Возраст: {1}, Фамилия: {2}, Телосложение: {3}", name, age, surname, body);
        }

    }
}
