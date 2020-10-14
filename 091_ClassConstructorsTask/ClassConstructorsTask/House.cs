using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorsTask
{
    class House
    {
        private string type;
        private short floors;
        private short year;
        private Address address;

        public House() {
            type = "Жилой дом";
            floors = 1;
            year = 2020;
            address = new Address();
        }

        public House(string type, short floors, short year) {
            this.type = type;
            this.floors = floors;
            this.year = year;
            address = new Address();
        }

        public void setAddress(string city, string street, string number) {
            address.setAddress(city, street, number);
        }

        public int countYears() { 
            int years = Convert.ToInt32(DateTime.Now.ToShortDateString().Substring(6, 4));
            years = years - year;

            return years;
        }

        public void printAllInfo() {
            Console.WriteLine("Здание: {0},\nКол-во этажей: {1},\nВозраст здания: {2},\nАдрес: {3}", 
                type, floors, countYears(), address.getAddress());
        }

    }
}
