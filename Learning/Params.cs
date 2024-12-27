using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Params
    {
        public static void Main(string[] args)
        {

            decimal sum = Sum(10.45m, 5,5,4.345f,45,45,4,"Hello this is Sum 2nd Method");

            Console.WriteLine("Sum is: {0}", sum);
        }

        static int Sum(params int[] numbers )
        {
            int total = 0;

            foreach( var e in numbers )
            {
                total += e;
            }

            return total;
        }

        static decimal Sum(params dynamic[] numbers)
        {
            decimal total = 0m;

            foreach (var e in numbers)
            {
                switch (e)
                {
                    case int:
                    case long:
                    case float:
                    case double:
                    case decimal:
                        total += (decimal)e;
                        break;
                        default:
                        Console.WriteLine("Not a Number");
                        break;
                }
            }

            return total;
        }


    }
}

