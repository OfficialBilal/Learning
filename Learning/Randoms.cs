using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Randoms
    {
        public static void Main(string[] args)
        {
            Random r = new();

            Console.WriteLine(r.Next(0,11));
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextSingle());
        }
    }
}
