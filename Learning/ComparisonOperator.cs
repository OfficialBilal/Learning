using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ComparisonOperator
    {
        public static void Main(string[] args)
        {
            bool a = 10 > 4;
            bool b = 10 < 4;
            bool c = 10 >+ 4;
            bool d = 10 >- 4;
            bool e = 10 <= 4;
            bool f = 10 == 4;
            bool g = 10 != 4;
            bool h = 10 >= 4;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}
