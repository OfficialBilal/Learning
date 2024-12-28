using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Classes
    {
        public static void Main(string[] args)
        {
            Person1 person = new Person1();

            person.Name = "Bilal";

            person.Age = 25;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }

        class Person1
        {
            public string Name = "";

            public int Age;
        }
    }
}
