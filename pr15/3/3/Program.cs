using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    using System;

    interface IPrice
    {
        decimal GetPrice();
    }

    interface IWarranty
    {
        int GetWarrantyPeriod();
    }

    class Phone : IPrice, IWarranty
    {
        private decimal price;
        private int warrantyPeriod;

        public Phone(decimal price, int warrantyPeriod)
        {
            if (price < 0)
            {
                Console.WriteLine("Цена не может быть отрицательной. Установлена в 0.");
                this.price = 0;
            }
            else
            {
                this.price = price;
            }

            if (warrantyPeriod < 0)
            {
                Console.WriteLine("Срок гарантии не может быть отрицательным. Установлен в 0.");
                this.warrantyPeriod = 0;
            }
            else
            {
                this.warrantyPeriod = warrantyPeriod;
            }
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetWarrantyPeriod()
        {
            return warrantyPeriod;
        }
    }

    class Laptop : IPrice
    {
        private decimal price;

        public Laptop(decimal price)
        {
            if (price < 0)
            {
                Console.WriteLine("Цена не может быть отрицательной. Установлена в 0.");
                this.price = 0;
            }
            else
            {
                this.price = price;
            }
        }

        public decimal GetPrice()
        {
            return price;
        }
    }

    class Program
    {
        static void Main()
        {
            object[] products = new object[]
            {
            new Phone(50000, 24),
            new Laptop(70000),
            new Phone(30000, 12),
            new Laptop(40000),
            new Phone(0, 0),
            new Phone(25000, -6)
            };

            decimal totalPrice = 0;

            foreach (var product in products)
            {
                if (product is IPrice priceItem)
                {
                    decimal price = priceItem.GetPrice();
                    totalPrice += price;
                    Console.WriteLine($"Цена товара: {price} руб.");

                    if (product is IWarranty warrantyItem)
                    {
                        int warranty = warrantyItem.GetWarrantyPeriod();
                        Console.WriteLine($"Гарантия: {warranty} месяцев");
                    }
                    else
                    {
                        Console.WriteLine("Гарантия отсутствует");
                    }
                }
                else
                {
                    Console.WriteLine("Объект не реализует интерфейс IPrice");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Общая стоимость товаров: {totalPrice} руб.");
        }
    }
}
