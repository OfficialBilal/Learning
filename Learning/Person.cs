using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    abstract class Person
    {
        public string Name = string.Empty;

        public byte Age = 0;

        abstract public void Talk();

        static public ulong Count = 0UL;

        public Person()
        {
            Count++;
        }
        
    }

    class Doctor : Person
    {
        public override void Talk()
        {
            Console.WriteLine("Person Can Talk");
        }

        public Doctor() : base()
        {

        }
    }

    class Patient : Person
    {
        public override void Talk()
        {
            Console.WriteLine("Person Can Talk");
        }

        public Patient() : base()
        {

        }
    }
}
