using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> history = new LinkedList<string>();
            LinkedListNode<string> current = null;
            Console.WriteLine("Введите URL-адреса или команду 'back':");
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                if (input == "back")
                {
                    if (current != null && current.Previous != null)
                    {
                        current = current.Previous;
                    }
                    else
                    {
                        Console.WriteLine("Нет предыдущей страницы");
                    }
                }
                else
                {
                    history.AddLast(input);
                    current = history.Last;
                }

                if (current != null)
                    Console.WriteLine("Текущая страница: " + current.Value);
                else
                    Console.WriteLine("Нет текущей страницы");
            }
        }
    }
}
