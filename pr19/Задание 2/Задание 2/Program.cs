using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();
            string input;

            Console.WriteLine("Введите текст на строках:");
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                stack.Push(input);
            }
            Console.WriteLine("Вывод:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
