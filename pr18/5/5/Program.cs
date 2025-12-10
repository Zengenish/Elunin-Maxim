using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class SimpleCache
    {
        private int maxSize;
        private Dictionary<string, string> cache = new Dictionary<string, string>();
        private List<string> order = new List<string>();

        public SimpleCache(int size)
        {
            maxSize = size;
        }
        public void AddRequest(string request)
        {
            if (cache.ContainsKey(request))
            {
                order.Remove(request);
                order.Add(request);
                Console.WriteLine($"Запрос: \"{request}\" уже есть, переносится в конец");
            }
            else
            {
                if (cache.Count >= maxSize)
                {
                    string oldest = order[0];
                    order.RemoveAt(0);
                    cache.Remove(oldest);
                    Console.WriteLine($"Удаляется \"{oldest}\"");
                }
                cache[request] = request;
                order.Add(request);
                Console.WriteLine($"Запрос: \"{request}\" добавлен");
            }
        }
        public void PrintCache()
        {
            Console.Write("Кэш: ");
            for (int i = 0; i < order.Count; i++)
            {
                Console.Write(order[i]);
                if (i < order.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            var cache = new SimpleCache(3);
            cache.AddRequest("погода");
            cache.AddRequest("курс");
            cache.AddRequest("новости");
            cache.PrintCache();
            cache.AddRequest("погода");
            cache.PrintCache();
        }
    }
}
