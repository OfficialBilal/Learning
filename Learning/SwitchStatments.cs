using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class SwitchStatments
    {
        public static void Main(string[] args)
        {
            object command = 43.9f;

            switch (command)
            {
                case int:
                    Console.WriteLine("Integer");
                     break;

                case string:
                    Console.WriteLine("String");
                    break;

                case float:
                    Console.WriteLine("Float");
                    break;

                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }
    }
}
 