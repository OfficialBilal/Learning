using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Constructors
    {
        public static void Main(string[] args)
        {
            Person1 person = new Person1()
            {
                Name = "Test",
                Age = 1
            };
            Console.WriteLine(person.Name);
        }
    }
}
