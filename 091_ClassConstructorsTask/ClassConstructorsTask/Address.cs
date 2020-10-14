using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorsTask
{
    class Address
    {
        private string city;
        private string street;
        private string number;

        public Address() { 
        }

        public Address(string city, string street, string number) {
            this.city = city;
            this.street = street;
            this.number = number;
        }

        public void setAddress(string city, string street, string number) {
            this.city = city;
            this.street = street;
            this.number = number;
        }

        public string getAddress() { 
            string address = city + ", " + street + ", " + number;

            return address;
        }

        public void printAddress() {
            Console.WriteLine("Город: {0}, Улица: {1}, Дом: {2}", city, street, number);
        }

    }
}
