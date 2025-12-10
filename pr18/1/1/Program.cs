using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string> { "Анна", "Пётр", "Анна", "Ольга", "Пётр", "Иван" };
            Console.WriteLine("Изначальный список:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            List<string> uniqueNames = new List<string>();

            foreach (var name in names)
            {
                if (!uniqueNames.Contains(name))
                {
                    uniqueNames.Add(name);
                }
            }

            Console.WriteLine("\nСписок после удаления повторов:");
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
