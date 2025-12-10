using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZADANIE3;

namespace ZADANIE3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var money1 = new Money(10, 50);
            var money2 = new Money(5, 75);

            Console.WriteLine($"Сумма денег: {money1 + money2}");
            Console.WriteLine($"Сравнение денег: {money1 == new Money(10, 50)}");
        }
    }
}

public class Money
{
    public int Rubles { get; set; }
    public int Kopecks { get; set; }

    public Money(int rubles, int kopecks)
    {
        Rubles = rubles + kopecks / 100;
        Kopecks = kopecks % 100;
    }

    public static Money operator +(Money m1, Money m2)
    {
        return new Money(m1.Rubles + m2.Rubles, m1.Kopecks + m2.Kopecks);
    }

    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Rubles == m2.Rubles && m1.Kopecks == m2.Kopecks;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    }

    public override string ToString()
    {
        return $"{Rubles} руб {Kopecks} коп";
    }
}