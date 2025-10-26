using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
        class Player
        {
            private int level;
            private int health;

            public int Level
            {
                get { return level; }
                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("Уровень не может быть меньше 1!");
                        level = 1;
                    }
                    else if (value > 100)
                    {
                        Console.WriteLine("Уровень не может быть больше 100!");
                        level = 100;
                    }
                    else
                    {
                        level = value;
                    }
                }
            }

            public int Health
            {
                get { return health; }
                set
                {
                    if (value < 0)
                    {
                        health = 0;
                    }
                    else if (value > 100)
                    {
                        health = 100;
                    }
                    else
                    {
                        health = value;
                    }
                }
            }

            public string Name { get; init; }

            public bool IsAlive
            {
                get { return Health > 0; }
            }

            public Player(string name, int level, int health)
            {
                Name = name;
                Level = level;
                Health = health;
            }

            public void TakeDamage(int damage)
            {
                Health -= damage;
                if (Health < 0)
                {
                    Health = 0;
                }
                Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {(IsAlive ? "да" : "нет")}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Player player = new Player("Alex", 5, 70);
                Console.WriteLine($"Игрок: {player.Name}, уровень: {player.Level}, здоровье: {player.Health}, жив: {(player.IsAlive ? "да" : "нет")}");
                player.TakeDamage(30);
                player.TakeDamage(40);
                player.Level = 0; 
            }
        }
    }
