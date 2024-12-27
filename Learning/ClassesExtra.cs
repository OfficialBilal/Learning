using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
     class ClassesExtra
    {
        public static void Main(string[] args)
        {
            LinkedClass person = new LinkedClass()
            {
                Name = "Bilal",
                Age = 25
            };

            person.Talk();

        }

    }
}
