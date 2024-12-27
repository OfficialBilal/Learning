using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MethodOverloading
    {

       //Method could be of same name but should be of different datatypes

        public static void Main(string[] args)
        {
            int sum = Sum(10, 5, 5);

            Console.WriteLine("Sum is: {0}",sum);
        }

        static int Sum(int a , int b)
        {
            return a + b; ;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static float Sum(float a, float b, float c)
        {
            return a + b + c;
        }
    }
}
