using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Null
    {
        public static void Main(string[] args)
        {
            string name1 = null;
            string other1 = name1 ?? "Unknown";
            Console.WriteLine(other1);

            string name2 = "Bilal";
            string other2 = name2 ?? "Unknown";
            Console.WriteLine(other2);

            int? age = null;
            int? a = age ?? 10;
            Console.WriteLine(a);
        }
    }
}
