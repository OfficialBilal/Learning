using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Ref
    {
        public static void Main(string[] args)
        {
            int num = 10;
            ref int a = ref num;
            a = 12;
            Console.WriteLine(num);


            int b = 20;
            ref int r = ref b;
            A(ref r);
        }

        static void A(ref int r)
        {
            Console.WriteLine(r);
        }
    }
}
