using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Continue_Break
    {
        public static void Main(string[] args)
        {
            // Continue
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }

            // Break
            for (int b = 0; b < 10; b++)
            {
                if (b % 2 == 0) break;
                Console.WriteLine(b);
            }
        }
    }
}
