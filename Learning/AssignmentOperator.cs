using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class AssignmentOperator
    {
        public static void Main(string[] args)
        {
            int number, other;

            number = 5;
            number = other = 30;

            number += 10;
            number += other += 20;

            Console.WriteLine(number);
        }
    }
}
