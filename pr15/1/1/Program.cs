using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _1;

namespace _1
{
    using System;

    interface IWorkable
    {
        void Work();
    }

    interface IRechargeable
    {
        void Recharge();
    }

    class Robot : IWorkable, IRechargeable
    {
        private string name;
        private int energy;

        public Robot(string name, int energy)
        {
            this.name = name;
            this.energy = energy;
        }

        public void Work()
        {
            if (energy >= 20)
                energy -= 20;
            else
                energy = 0;
            Console.WriteLine($"Робот {name} работает. Текущая энергия: {energy}");
        }

        public void Recharge()
        {
            if (energy <= 50)
                energy += 50;
            else
                energy = 100;
            Console.WriteLine($"Робот {name} заряжается. Текущая энергия: {energy}");
        }

        public string Name => name;
        public int Energy => energy;
    }

    class Program
    {
        static void Main()
        {
            Robot[] robots = new Robot[2]
            {
            new Robot("#1", 80),
            new Robot("#2", 30)
            };

            foreach (var robot in robots)
            {
                robot.Work();
                robot.Work();
            }

            foreach (var robot in robots)
            {
                robot.Recharge();
            }

            foreach (var robot in robots)
            {
                robot.Work();
            }
        }
    }
}
