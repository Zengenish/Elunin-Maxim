using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Point
    {
        private double x;
        private double y;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(double value) : this(value, value)
        {
        }
        public Point() : this(0, 0)
        {
        }
        public void Show()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3.5, 7.2);
            Point p2 = new Point(5);
            Point p3 = new Point();

            p1.Show();
            p2.Show();
            p3.Show();
        }
    }
}

