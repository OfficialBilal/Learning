using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class ObjectType
    {
        public static void Main(string[] args)
        {
            object obj = "Hello, How are you?";
            obj = 2;
            obj = 4.565f;
            Console.WriteLine(obj);

            if (obj is int)
            {
                //int number = (int)obj;
                Console.WriteLine("Interger");
            }
            else if (obj is string)
            {
               Console.WriteLine("String");
            }
            else if (obj is float)
            {
                Console.WriteLine("Float");
            }
        }
    }
}   
