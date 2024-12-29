using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Exceptions
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("That is not a valid number. Please enter a numeric value.");
            }
            finally
            {
                Console.WriteLine("Thank you for using the program.");
            }
        }
    }
}
