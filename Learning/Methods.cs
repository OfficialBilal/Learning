using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Methods
    {
        //Method/Function
        public static void Main(string[] args)
        {
            string newname = "Ali";

            NewFunction(newname);
        }

        static void NewFunction(string Name)
        {
            Console.WriteLine($"Hi, {Name} i am from another Funtion/Method");
        }
    }
}
