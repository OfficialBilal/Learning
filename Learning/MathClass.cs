using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MathClass
    {
        public static void Main(string[] args)
        {
            double pi = 3.54;

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);

            Console.WriteLine(Math.Round(pi));
            Console.WriteLine(Math.Floor(pi));
            Console.WriteLine(Math.Ceiling(pi));

            Console.WriteLine(Math.Clamp(15, 0, 10));
            Console.WriteLine(Math.Clamp(8, 0, 10));
            Console.WriteLine(Math.Clamp(-1, 0, 10));

            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Max(-5, 14));
            Console.WriteLine(Math.Min(-5, 14));
            Console.WriteLine(Math.Pow(2, 5));
            Console.WriteLine(Math.Sqrt(7));
        }
    }
}
