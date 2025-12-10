using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            input = input.ToLower();
            string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string Word = word.Trim();
                if (frequency.ContainsKey(Word))
                {
                    frequency[Word]++;
                }
                else
                {
                    frequency[Word] = 1;
                }
            }

            foreach (var kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }
        }
    }
}
