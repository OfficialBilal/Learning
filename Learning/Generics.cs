using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Generics
    {
        public static void Main(string[] args)
        {
            T Doubleit<T>(T number)
            {
                return (dynamic)number * 2;
            }

            var twice = Doubleit(34.34);
            Console.WriteLine(twice);
        }
    }
}
