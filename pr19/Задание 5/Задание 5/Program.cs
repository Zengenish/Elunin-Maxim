using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, bool> cache = new Dictionary<string, bool>();
            Queue<string> order = new Queue<string>();
            const int maxSize = 3;
            Console.WriteLine("Введите команды '+URL', чтобы добавить страницу в кэш, или 'exit' для выхода.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit")
                    break;

                if (input.StartsWith("+"))
                {
                    string page = input.Substring(1).Trim();

                    if (!cache.ContainsKey(page))
                    {
                        if (cache.Count >= maxSize)
                        {
                            string oldest = order.Dequeue();
                            cache.Remove(oldest);
                            Console.WriteLine($"Удаляется {oldest}");
                        }
                        cache[page] = true;
                        order.Enqueue(page);
                    }
                    Console.WriteLine("Текущий кэш: " + string.Join(", ", order));
                }
            }
        }
    }
}
