using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main()
        {
            HashSet<string> names = new HashSet<string>();
            string input;

            Console.WriteLine("Введите текст по полям:");
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }
            var sortedNames = names.OrderBy(name => name);
            Console.WriteLine("Уникальные: " + string.Join(", ", sortedNames));
        }
    }
}
