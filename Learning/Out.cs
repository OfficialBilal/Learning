using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Learning
{
    class Out
    {
        public static void Main(string[] args)
        {
            New(out int number);

            Console.WriteLine(number);
        }

        static void New(out int n)
        {
            n = 10;
        }
    }
}
