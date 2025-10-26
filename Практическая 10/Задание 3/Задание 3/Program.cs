using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
        class Device
        {
            protected string brand;

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public Device(string brand)
            {
                this.brand = brand;
            }

            public virtual void PowerOn()
            {
                Console.WriteLine($"{brand} включён.");
            }
        }

        class Laptop : Device
        {
            private int ram;
            private int battery;

            public int Ram
            {
                get { return ram; }
                set
                {
                    if (value < 1 || value > 64)
                    {
                        Console.WriteLine("ОЗУ должно быть от 1 до 64!");
                        ram = 1;
                    }
                    else
                    {
                        ram = value;
                    }
                }
            }

            public int Battery
            {
                get { return battery; }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        Console.WriteLine("Заряд батареи должен быть от 0 до 100!");
                        battery = 0;
                    }
                    else
                    {
                        battery = value; 
                    }
                }
            }

            public Laptop(string brand, int ram, int battery) : base(brand)
            {
                this.Ram = ram;
                this.Battery = battery;
            }

            public void Work()
            {
                Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery}%.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Laptop laptop = new Laptop("Dell", 0, 85);
                laptop.PowerOn();
                laptop.Work();
            }
        }
    }