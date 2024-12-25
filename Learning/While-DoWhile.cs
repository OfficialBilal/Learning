using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class While_DoWhile
    {
        public static void Main(string[] args)
        {
            //Example 1
            int design = 0;

            while (design < 10)
            {
                int a = design;
                while (a < 10)
                {
                    Console.Write(a+ " ");
                    a++;
                }

                Console.WriteLine(" ");
                design++;

            }

            //Example 2
            int Counter = 0;

            while (Counter < 50)
            {
                Console.WriteLine($"{Counter} Bilal");
                Counter++;
            }

            Console.WriteLine("Switching to Do-While Loop");

            do
            {
                Console.WriteLine($"{Counter} Bilal");
                Counter++;

            } while (Counter < 100);
        }
    }
}
