using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;     //Добовляем для аннотации - DataContract и DataMember


namespace SerializationTask {
    [DataContract]                      //Говорим, что класс будет сериализован в формат XML
    public class Data {
        [DataMember]                    //Указываем, что поле будет сохранено
        public string dataName;
        [DataMember]
        public int x;
        [DataMember]
        public int y;
        [DataMember]
        public int z;


        public Data(string dataName, int x, int y, int z) {
            this.dataName = dataName;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void printInfo() {
            Console.WriteLine($"Хранилище данных: {dataName}, Ячейка X: {x}, Ячейка Y: {y}, Ячейка Z: {z}");
        }

    }
}
