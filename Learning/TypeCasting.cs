using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class TypeCasting
    {
       public static void Main(string[] args)
       {
          // Converting one type to another type

          decimal d = 0.01m;

          bool i = Convert.ToBoolean(d);

          Console.WriteLine(i);
       }
    }
}

