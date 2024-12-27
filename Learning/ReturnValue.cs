using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ReturnValue
    {
        static void Main(string[] args)
        {
            int sum = Add(16, 4);
            int div = Div(10, 0);

            Console.WriteLine(sum);
            Console.WriteLine(div);
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int Div(int a, int b) 
        {
            if (b==0)
            {
                return 0;
            }

            return a / b;
        }
    }
}
