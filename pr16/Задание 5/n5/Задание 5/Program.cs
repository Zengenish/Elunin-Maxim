using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            Normalize();
        }
        private void Normalize()
        {
            if (seconds >= 60)
            {
                minutes += seconds / 60;
                seconds = seconds % 60;
            }
            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes = minutes % 60;
            }
            hours = hours % 24;
        }
        public static bool operator >(Time t1, Time t2)
        {
            if (t1.hours != t2.hours)
                return t1.hours > t2.hours;
            if (t1.minutes != t2.minutes)
                return t1.minutes > t2.minutes;
            return t1.seconds > t2.seconds;
        }

        public static bool operator <(Time t1, Time t2)
        {
            if (t1.hours != t2.hours)
                return t1.hours < t2.hours;
            if (t1.minutes != t2.minutes)
                return t1.minutes < t2.minutes;
            return t1.seconds < t2.seconds;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return t1 > t2 || t1 == t2;
        }

        public static bool operator <=(Time t1, Time t2)
        {
            return t1 < t2 || t1 == t2;
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return hours;
                    case 1: return minutes;
                    case 2: return seconds;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: hours = value; break;
                    case 1: minutes = value; break;
                    case 2: seconds = value; break;
                    default: throw new IndexOutOfRangeException();
                }
                Normalize();
            }
        }

        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }

    class Program
    {
        static void Main()
        {
            var t1 = new Time(14, 35, 9);
            var t2 = new Time(9, 10, 5);
            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1[1]);
            t1[2] = 59;
            Console.WriteLine(t1);
        }
    }
}
