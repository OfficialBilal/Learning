using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Polymorphism
    {
        interface IPerson
        {
            string? Who();
        }

        class Employee : IPerson
        {
            public string? Who()
            {
                return ToString()?.Split('.')[^1];
            }
        }

        class Manager : IPerson
        {
            public string? Who()
            {
                return ToString()?.Split('.')[^1];
            }
        }

        public static void Main(string[] args)
        {
            IPerson person = new Employee();
            person = new Manager();
            Console.WriteLine(person.Who());
        }
    }
}
