using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} издаёт звук.");
        }
    }

    class Cat : Animal
    {
        private int lives;
        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 1)
                    lives = 1;
                else if (value > 9)
                    lives = 9;
                else
                    lives = value;
            }
        }
        public Cat(string name, int lives) : base(name)
        {
            Lives = lives;
        }
        public Cat(string name) : this(name, 9)
        {
        }
        public void Meow()
        {
            if (Lives > 1)
                Lives--;
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Мурзик", 8);
            Cat cat2 = new Cat("Барсик");

            cat1.Speak();
            cat1.Meow();
            cat1.Meow();

            Console.WriteLine();

            cat2.Speak();
            cat2.Meow();
            cat2.Meow();
        }
    }
}
