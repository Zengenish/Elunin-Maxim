using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Vector
    {
        private double[] components;

        public Vector(params double[] components)
        {
            this.components = components;
        }
        public double this[int index]
        {
            get => components[index];
            set => components[index] = value;
        }
        public override string ToString()
        {
            string result = "(";
            for (int i = 0; i < components.Length; i++)
            {
                result += components[i];
                if (i < components.Length - 1)
                    result += ", ";
            }
            result += ")";
            return result;
        }
        public static double operator *(Vector v1, Vector v2)
        {
            if (v1.components.Length != v2.components.Length)
                throw new ArgumentException("Vectors must be of same length");

            double result = 0;
            for (int i = 0; i < v1.components.Length; i++)
            {
                result += v1.components[i] * v2.components[i];
            }
            return result;
        }
    }


    class Program
    {
        static void Main()
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);
            Console.WriteLine(v1 * v2);
            Console.WriteLine(v1); 
            v1[0] = 10;
            Console.WriteLine(v1);
            Console.WriteLine(v1 * v2);
        }
    }
}
