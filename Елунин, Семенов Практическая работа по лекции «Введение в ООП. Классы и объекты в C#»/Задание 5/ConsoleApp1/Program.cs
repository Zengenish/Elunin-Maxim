using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pet
    {
        string name;
        int energy;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100)
                    energy = value;
                else
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
            }
        }
        public Pet(string name, int energy)
        {
            this.name = name;

            if (energy >= 0 && energy <= 100)
                this.energy = energy;
            else
            {
                Console.WriteLine("Энергия должна быть от 0 до 100!");
                this.energy = 50;
            }
        }

        public void Play()
        {
            energy = Math.Max(0, energy - 20);
            Console.WriteLine($"{name} играет, энергия: {energy}.");
        }
        public void Rest()
        {
            energy = Math.Min(100, energy + 30);
            Console.WriteLine($"{name} отдыхает, энергия: {energy}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet("Рекс", 80);
            pet.Play();
            pet.Rest();
            pet.Energy = 150;
            pet.Play();
            Console.ReadKey();
        }
    }
}
