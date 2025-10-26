using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Car
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else if (value > 300)
                {
                    Console.WriteLine("Скорость не может превышать 300!");
                    speed = 300;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public string Model { get; set; } = "Unknown";

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Mercedes", 220);
            myCar.Drive();

            myCar.Speed = 400;
            myCar.Drive();

            myCar.Speed = -50;
            myCar.Drive();
            Console.ReadKey();
        }
    }
}