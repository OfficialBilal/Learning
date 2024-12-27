using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MemberMethods
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Bilal";

            person.Age = 25;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            person.Talk();

        }

        class Person
        {
            public string Name = "";

            public int Age;

            public void Talk()
            {
                Console.WriteLine("Yeayae");
            }
        }
    }
}
