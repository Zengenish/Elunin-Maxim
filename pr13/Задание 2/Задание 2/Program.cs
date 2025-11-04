using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }
        public string Owner { get; set; }

        public BankAccount(string accountNumber, string owner, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = initialBalance;
        }
        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"На счет {AccountNumber} зачислено {amount}. Текущий баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Сумма пополнения должна быть положительной.");
            }
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Со счета {AccountNumber} снято {amount}. Остаток: {Balance}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств или неверная сумма.");
            }
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Счет: {AccountNumber} | Владелец: {Owner} | Баланс: {Balance}");
        }
    }
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CheckingAccount(string accountNumber, string owner, decimal overdraftLimit, decimal initialBalance = 0)
            : base(accountNumber, owner, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && (Balance + OverdraftLimit) >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Со счета {AccountNumber} снято {amount}. Остаток: {Balance}");
            }
            else
            {
                Console.WriteLine("Превышен лимит овердрафта или неверная сумма.");
            }
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Лимит овердрафта: {OverdraftLimit}");
        }
    }
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, string owner, double interestRate, decimal initialBalance = 0)
            : base(accountNumber, owner, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            decimal interest = Balance * (decimal)InterestRate;
            Balance += interest;
            Console.WriteLine($"Начислены проценты: {interest}. Текущий баланс: {Balance}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Процентная ставка: {InterestRate * 100}%");
        }
    }
    public class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; set; }
        public DateTime DueDate { get; set; }

        public CreditAccount(string accountNumber, string owner, decimal creditLimit, DateTime dueDate, decimal initialBalance = 0)
            : base(accountNumber, owner, initialBalance)
        {
            CreditLimit = creditLimit;
            DueDate = dueDate;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && (Balance - amount) >= -CreditLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Со счета {AccountNumber} снято {amount}. Остаток: {Balance}");
            }
            else
            {
                Console.WriteLine("Превышен кредитный лимит или неверная сумма.");
            }
        }

        public void MakeRepayment(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Погашена сумма {amount}. Текущий баланс: {Balance}");
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Кредитный лимит: {CreditLimit} | Срок погашения: {DueDate.ToShortDateString()}");
        }
    }
    class Program
    {
        static void Main()
        {
            var checking = new CheckingAccount("11111", "Иван Иванов", 5000, 1000);
            var savings = new SavingsAccount("22222", "Петр Петров", 0.03, 2000);
            var credit = new CreditAccount("33333", "Елена Еленова", 10000, DateTime.Now.AddMonths(6), -2000);

            checking.DisplayInfo();
            checking.Withdraw(3000);
            checking.Deposit(500);
            Console.WriteLine();

            savings.DisplayInfo();
            savings.AddInterest();
            Console.WriteLine();

            credit.DisplayInfo();
            credit.Withdraw(8000);
            credit.MakeRepayment(3000);
        }
    }
}


