using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        string GetName();
    }

    interface IManager
    {
        string Role { get; set; }
    }

    class Employee : IPerson, IManager
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Role { get; set; }
        public string GetName()
        {
            return Name;
        }
    }
    class Interface
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Bilal from Interface";
            Console.WriteLine(emp.Name);
        }
    }
}
