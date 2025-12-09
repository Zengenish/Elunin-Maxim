using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    using System;

    interface ITransaction
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    interface ITransfer
    {
        void TransferTo(decimal amount, BankAccount recipient);
    }

    class BankAccount : ITransaction, ITransfer
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                Console.WriteLine("Начальный баланс не может быть отрицательным. Установлен в 0.");
                Balance = 0;
            }
            else
            {
                Balance = initialBalance;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма для внесения должна быть больше нуля.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Пополнение на сумму {amount}. Текущий баланс: {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма для снятия должна быть больше нуля.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Недостаточно средств для снятия.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Снятие суммы {amount}. Текущий баланс: {Balance}");
        }

        public void TransferTo(decimal amount, BankAccount recipient)
        {
            if (recipient == null)
            {
                Console.WriteLine("Получатель не существует.");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Сумма перевода должна быть больше нуля.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Недостаточно средств для перевода.");
                return;
            }
            this.Withdraw(amount);
            recipient.Deposit(amount);
            Console.WriteLine($"Перевод {amount} выполнен успешно.");
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount[] accounts = new BankAccount[]
            {
            new BankAccount(1000),
            new BankAccount(500)
            };

            accounts[0].TransferTo(200, accounts[1]);

            Console.WriteLine($"\nБаланс первого счета: {accounts[0].Balance}");
            Console.WriteLine($"Баланс второго счета: {accounts[1].Balance}");
        }
    }
}
