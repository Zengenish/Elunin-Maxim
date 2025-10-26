using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Phone
    {
        private int battery;

        public int BatteryLevel
        {
            get { return battery; }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Заряд не может превышать 100!");
                    battery = 100;
                }
                else if (value < 0)
                {
                    battery = 0;
                }
                else
                {
                    battery = value;
                }
            }
        }
        public string Brand { get; init; }

        public Phone(string brand, int initialBattery)
        {
            Brand = brand;
            BatteryLevel = initialBattery;
        }

        public void Use()
        {
            BatteryLevel -= 10;
            Console.WriteLine($"{Brand}: заряд {BatteryLevel}%.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Phone myPhone = new Phone("Samsung", 70);
            myPhone.Use();
            myPhone.Use();
            myPhone.Use();
            myPhone.BatteryLevel = 150;
        }
    }
}