using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1._12._11
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(3, 4);

            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}");
            Console.WriteLine($"Сложение точек: {p1 + p2}");
            Console.WriteLine($"Вычитание точек: {p1 - p2}");
        }
    }
}