using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    public class BankAccount
    {
       string owner;
       double balance;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Ошибка: баланс не может быть отрицательным!");
            }
        }

        public BankAccount(string owner, double initialBalance)
        {
           this.owner = owner;

            if (initialBalance >= 0)
                balance = initialBalance;
            else
            {
                Console.WriteLine("Ошибка: начальный баланс не может быть отрицательным! Установлен баланс 0.");
                balance = 0;
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{owner}, баланс: {balance}.");
            }
            else
            {
                Console.WriteLine("Ошибка: сумма для пополнения должна быть положительной!");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"{owner}, баланс: {balance}.");
                }
                else
                {
                    Console.WriteLine($"Ошибка: недостаточно средств!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: сумма для снятия должна быть положительной!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Иван Золо", 1000.0);
            account.Deposit(500.0);
            account.Withdraw(300.0);
            account.Withdraw(1500.0);
            account.Withdraw(-100.0);
            account.Deposit(200.0);
            Console.ReadKey();
        }
    }
}
