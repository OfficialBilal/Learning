using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class If_Else
    {
        public static void Main(string[] args)
        {
            int grades = 46;
            #pragma warning disable
            bool HasPassed = false;

            if (grades > 45)
            {
                Console.WriteLine("You are Passed");
            }
            else if (grades > 30)
            {
                Console.WriteLine("You are mar mar ky Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }

        }
    }
}
