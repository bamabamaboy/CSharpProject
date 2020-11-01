using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;   //Для сохранения объектов в бинарном формате
using System.Xml.Serialization;                         //Для сохранения объектов в формате XML
using System.Runtime.Serialization.Json;                //Для сохранения объектов в формате JSON (нет в старой версии C#)
using System.IO;

namespace SerializationTask {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("----------------------------------------------------------");

            //Сохранение объектов в файл в бинарном формате
            binarySave();

            Console.WriteLine("----------------------------------------------------------");

            //Сохранение объектов в файл в формате XML
            xmlSave();

            Console.WriteLine("----------------------------------------------------------");
            
            //Сохранение объектов в файл в формате JSON
            jsonSave();

            Console.WriteLine("----------------------------------------------------------");

            Console.ReadKey();
        }

        public static void binarySave() {
            Animal cat = new Animal("Буся", 3, "Кошечка");
            Animal dog = new Animal("Бетховен", 4, "Пёс");
            Animal[] myAnimal = { cat, dog };

            foreach (Animal animal in myAnimal) {
                animal.printInfo();
            }

            Console.WriteLine("----------------------------------------------------------");

            BinaryFormatter binary = new BinaryFormatter();

            //Чтобы сохранить данные в бинарном виде, нужно использовать формат файла .dat
            using (FileStream fs = new FileStream("myAnimal.dat", FileMode.OpenOrCreate)) {
                binary.Serialize(fs, myAnimal);
                Console.WriteLine("Объекты записаны в файл!");
            }

            Console.WriteLine("----------------------------------------------------------");

            //Загрузка объектов из файла в бинарном формате
            using (FileStream fs = new FileStream("myAnimal.dat", FileMode.OpenOrCreate)) {
                Animal[] animals = (Animal[]) binary.Deserialize(fs);
                Console.WriteLine("Объекты загружены из файла!");

                foreach (Animal animal in animals) {
                    animal.printInfo();
                }
            }
        }

        public static void xmlSave() {
            People one = new People("Алёша", 25, "Попович", "Богатырь");
            People two = new People("Василий", 45, "Ядрицкий", "Худыш");
            
            List<People> team = new List<People>();
            team.Add(one);
            team.Add(two);

            foreach (People people in team) {
                people.printInfo();
            }

            Console.WriteLine("----------------------------------------------------------");

            XmlSerializer xml = new XmlSerializer(typeof(List<People>));

            using (FileStream fs = new FileStream("team.xml", FileMode.OpenOrCreate)) {
                xml.Serialize(fs, team);
                Console.WriteLine("Объекты записаны в файл!");
            }

            Console.WriteLine("----------------------------------------------------------");

            using (FileStream fs = new FileStream("team.xml", FileMode.OpenOrCreate)) {
                List<People> peoples = (List<People>) xml.Deserialize(fs);
                Console.WriteLine("Объекты загружены из файла!");

                foreach (People people in peoples) {
                    people.printInfo();
                }
            }
        }

        public static void jsonSave() {
            Data dataOne = new Data("Первый кластер", 865, 34564, 896);
            Data dataTwo = new Data("Второй кластер", 76, 428, 776);
            Data dataThree = new Data("Третий кластер", 554, 61, 3);
            Data dataFour = new Data("Четвёртый кластер", 89, 63, 11);
            Data dataFive = new Data("Пятый кластер", 10, 921, 65);

            List<Data> allData = new List<Data> {dataOne, dataTwo, dataThree, dataFour, dataFive};

            foreach (Data data in allData) data.printInfo();
            
            Console.WriteLine("----------------------------------------------------------");
            
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Data>));

            using (FileStream fs = new FileStream("data.json", FileMode.OpenOrCreate)) {
                json.WriteObject(fs, allData);
                Console.WriteLine("Объекты записаны в файл!");
            }

            Console.WriteLine("----------------------------------------------------------");

            using (FileStream fs = new FileStream("data.json", FileMode.OpenOrCreate)) {
                List<Data> datas = (List<Data>) json.ReadObject(fs);
                Console.WriteLine("Объекты загружены из файла!");

                foreach (Data d in datas) {
                    d.printInfo();
                }
            }
        }
    }
}
S