using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Person
    {
        public string Name = string.Empty;

        public byte Age = 0;

        public void Talk()
        {
            Console.WriteLine("Person Can Talk");
        }
    }

    class Doctor : Person
    {

    }

    class Patient : Person
    {

    }
}
