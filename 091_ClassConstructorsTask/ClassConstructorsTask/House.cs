using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorsTask
{
    class House
    {
        //Переменные класса House --------------------------------------------
        //Конструкция { get; set; } - это автоматические Свойства (аксессоры), их лучше всегда добавлять к полям класса
        //чтобы в дальнейшем, если будет надо, то можно быть легко прикруть доп. проверки
        public string type { get; set; }
        public short floors { get; set; }
        private short year;                                     //У поля year реализованы Свойства ниже
        private Address address;                                //Переменная для хранения адреса объекта House
        public static int houseCount { get; private set; }      //Переменная для подсчёта общего кол-ва объектов House

        //Акссессоры (Геттеры и Cеттеры) класса House ------------------------
        //в C# они называются Свойствами
        public short Year {
            get {
                return year; 
            }

            set {
                if (value < 0) {
                    year = 2020;
                }
                else {
                    year = value;
                }
            }
        }

        public Address Address {
            get {
                return address;
            }

            set {
                address = value;
            }
        
        }

        //Конструкторы класса House ------------------------------------------
        //Перегрузка конструктора с помощью разных аргументов
        public House() {
            type = "Жилой дом";
            floors = 1;
            year = 2020;
            address = new Address();

            houseCount++;

            Console.WriteLine("Был вызван пустой конструктор!");
        }

        public House(string type, short year) {
            this.type = type;
            this.year = year;
            address = new Address();

            houseCount++;

            Console.WriteLine("Был вызван легковесный конструктор!");
        }

        public House(string type, short floors, short year) {
            this.type = type;
            this.floors = floors;
            this.year = year;
            address = new Address();

            houseCount++;

            Console.WriteLine("Был вызван основной конструктор!");
        }

        public House(string type, short floors, short year, Address address) {
            this.type = type;
            this.floors = floors;
            this.year = year;
            this.address = address;

            houseCount++;

            Console.WriteLine("Был вызван расширенный конструктор!");
        }


        //Основные методы класса House ---------------------------------------
        //Метод считает возраст постройки
        public int countYears() { 
            int years = Convert.ToInt32(DateTime.Now.ToShortDateString().Substring(6, 4));
            years = years - year;

            return years;
        }

        //Метод для вывода основной информации о постройке
        public void printAllInfo() {
            Console.WriteLine("Здание: {0},\nКол-во этажей: {1},\nВозраст здания: {2},\nАдрес: {3}", 
                type, floors, countYears(), address.getAddress());
        }

    }
}
