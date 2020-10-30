using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTask {
    [Serializable]
    public class Animal {       //Для Сериализации, должен быть public

        public string name;
        public int age;

        [NonSerialized]             //Указывае, что данное поле не будет сериализовано
        public string kind;

        public Animal(string name, int age, string kind) {
            this.name = name;
            this.age = age;
            this.kind = kind;
        }

        public void printInfo() {
            Console.WriteLine("Вид животного: {0}, Имя животного: {1}, Возраст животного: {2}", kind, name, age);
        }

    }
}
