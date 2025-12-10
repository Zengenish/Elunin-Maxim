using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Анна");
            queue.Enqueue("Петр");
            queue.Enqueue("Ольга");
            queue.Enqueue("Наан");
            queue.Enqueue("Мария");
            Console.WriteLine("Очередь: " + string.Join(", ", queue));
            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                Console.WriteLine($"Обслуживаем: {current}");
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Очередь пуста");
            }
        }
    }
}
