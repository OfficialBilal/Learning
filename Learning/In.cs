using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class In
    {
        public static void Main(string[] args)
        {
            int number = 8;

            New(number);
        }

        static void New(in int a)
        {
            Console.WriteLine(a);
        }
    }
}
