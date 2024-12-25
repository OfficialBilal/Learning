using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            for ( int i = 0 ; i < 10 ; i++ )
            {
                for (int j = i ; j < 10 ; j++ )
                {
                    Console.Write(i+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
