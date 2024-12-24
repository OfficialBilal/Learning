using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class LogicalOperator
    {
        public static void Main(string[] args)
        {
            bool a = true && true;
            bool b = true && false;
            bool c = true || true;
            bool d = true || false;
            bool e = false || false;

            bool f = false || true;
            bool g = !f;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
