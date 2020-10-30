using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerializationTask {
    //[DataContract]        //Говорим, что класс будет сериализован в формат XML
    public class Data {
        //[DataMember]      //Указываем, что поле будет сохранено
        public int x;

        public Data(int x) {
            this.x = x;
        }

        public void printInfo() {
            Console.WriteLine("Переменная X - {0}", x);
        }

    }
}
