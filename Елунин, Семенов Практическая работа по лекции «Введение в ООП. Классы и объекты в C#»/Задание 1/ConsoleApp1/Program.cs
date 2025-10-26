using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 { 
class Person
{
   string name;
   int age;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 120)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Возраст должен быть от 0 до 120!");
                age = 0;
            }
        }
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void SayHello()
    {
        Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Маша", 25);
        person.SayHello();
        person.Age = 150;
        person.SayHello();
        person.Age = -5;
        person.SayHello();
            Console.ReadKey();
    }
}
}

   