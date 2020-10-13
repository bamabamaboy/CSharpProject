using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    class Car
    {
        private string model;
        private int weight;
        private string color;
        public float maxSpeed;

        public void setAllInfo(string model, int weight, string color, float maxSpeed) {
            this.model = model;
            this.weight = weight;
            this.color = color;
            this.maxSpeed = maxSpeed;
        }

        public void getCarInfo() {
            Console.WriteLine("Ваша машина - {0}, имеет характеристики:", model);
            Console.WriteLine("Масса: {0} кг, Цвет: {1}, Максимальная скорость: {2} км/ч", weight, color, maxSpeed);
        }

    }
}
