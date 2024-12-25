using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            object[] obj = { new(), new(), new(), new()};

            obj[0] = 12;
            obj[0] = "Bilal";

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine(obj[0]);
        }
    }
}
