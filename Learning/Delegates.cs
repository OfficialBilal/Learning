using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Delegates
    {
        static void AlertPhone()
        {
            Console.WriteLine("Phoning...");
        }

        static void AlertDesktop()
        {
            Console.WriteLine("Desktoping...");
        }

        static void AlertTablet()
        {
            Console.WriteLine("Tableting...");
        }

        delegate void Alert();
        public static void Main(string[] args)
        {
           Alert alert = AlertPhone;
           alert += AlertDesktop;
           alert += AlertTablet;

            alert();


        }
    }
}
