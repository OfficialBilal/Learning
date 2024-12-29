using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Lamdas
    {
        public static void Main(string[] args)
        {
            var isEven = (int n) => n % 2 == 0;

            Console.WriteLine(isEven(8));
        }
    }
}
