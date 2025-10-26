using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Phone
    {
  string brand;
  int batteryLevel;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value < 0)
                    batteryLevel = 0;
                else if (value > 100)
                    batteryLevel = 100;
                else
                    batteryLevel = value;
            }
        }
        public Phone(string brand, int batteryLevel)
        {
            this.brand = brand;
            this.batteryLevel = batteryLevel;
        }

        public void UsePhone()
        {
            Console.WriteLine($"Телефон {brand}, заряд: {batteryLevel}%");
            batteryLevel = Math.Max(0, batteryLevel - 10);
        }
    }
    class Program
    {
        static void Main()
        {
            Phone myPhone = new Phone("Apple", 100); 
            myPhone.UsePhone();
            myPhone.UsePhone(); 
            myPhone.UsePhone(); 
            myPhone.UsePhone(); 
            myPhone.UsePhone(); 
            myPhone.UsePhone(); 
            myPhone.UsePhone();
            myPhone.UsePhone(); 
            myPhone.UsePhone(); 
            myPhone.UsePhone(); 
            myPhone.UsePhone();
            Console.ReadKey();
        }
     
    }
}

