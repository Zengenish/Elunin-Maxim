using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void SellItem(Dictionary<string, int> stock, List<string> sold, string product, int quantity)
        {
            if (stock.ContainsKey(product))
            {
                if (stock[product] >= quantity)
                {
                    stock[product] -= quantity;
                    for (int i = 0; i < quantity; i++)
                    {
                        sold.Add(product);
                    }
                }
                else
                {
                    Console.WriteLine($"Недостаточно {product} на складе");
                }
            }
            else
            {
                Console.WriteLine("Товара нет в наличии");
            }
        }
        static void Main()
        {
            Dictionary<string, int> stock = new Dictionary<string, int>();
            List<string> sold = new List<string>();

            stock["Молоко"] = 15;
            stock["Хлеб"] = 10;
            stock["Яйца"] = 20;
            stock["Масло"] = 5;
            stock["Кофе"] = 8;
            stock["Сахар"] = 12;

            SellItem(stock, sold, "Молоко", 2);
            SellItem(stock, sold, "Хлеб", 1);
            SellItem(stock, sold, "Яйца", 1);

            Console.WriteLine("Остатки:");
            foreach (var item in stock)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var salesCount = new Dictionary<string, int>();
            foreach (var item in sold)
            {
                if (salesCount.ContainsKey(item))
                {
                    salesCount[item]++;
                }
                else
                {
                    salesCount[item] = 1;
                }
            }

            Console.WriteLine("\nПродано:");
            foreach (var item in salesCount)
            {
                Console.WriteLine($"{item.Key} {item.Value} раз");
            }
        }
    }
}
