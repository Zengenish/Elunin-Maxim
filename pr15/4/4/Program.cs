using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    using System;

    interface IAttack
    {
        void Attack();
    }

    interface IHeal
    {
        void Heal();
    }

    class Warrior : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Воин атакует своим оружием.");
        }
    }

    class Mage : IAttack, IHeal
    {
        public void Attack()
        {
            Console.WriteLine("Маг атакует магией.");
        }

        public void Heal()
        {
            Console.WriteLine("Маг лечит своих товарищей.");
        }
    }

    class Program
    {
        static void Main()
        {
            object[] characters = new object[]
            {
            new Warrior(),
            new Mage(),
            new Warrior(),
            new Mage()
            };

            Console.WriteLine("Все, кто умеет атаковать:");
            foreach (var character in characters)
            {
                if (character is IAttack attacker)
                {
                    attacker.Attack();
                }
            }

            Console.WriteLine("\nВсе, кто умеет лечить:");
            foreach (var character in characters)
            {
                if (character is IHeal healer)
                {
                    healer.Heal();
                }
            }
        }
    }
}
