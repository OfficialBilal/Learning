using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ForEach
    {
        public static void Main(string[] args)
        {
            int[,] ints = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            foreach (var b in Range(0,100))
            {
                Console.WriteLine(b);
            }
        }
    }
}
