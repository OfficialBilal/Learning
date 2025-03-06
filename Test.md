## Complex Example to Understand `Console` Class

Now, we will write a program to accept **Employee Details** like **EmployeeId, Name, Salary, Address, and Department**, and then we will print the accepted information on the console window.

### Example:
```csharp
using System;
namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Details");

            Console.WriteLine("Enter Employee ID");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            int Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            string Department = Console.ReadLine();

            Console.WriteLine("\nEntered Employee Details are as Follows:");
            Console.WriteLine($"Employee ID Is: {EmployeeID}");
            Console.WriteLine($"Employee Name Is: {Name}");
            Console.WriteLine($"Employee Salary Is: {Salary}");
            Console.WriteLine($"Employee Address Is: {Address}");
            Console.WriteLine($"Employee Department Is: {Department}");
            Console.ReadKey();
        }
    }
}

![Employee Details Example](https://dotnettutorials.net/wp-content/uploads/2022/07/understanding-variables-in-c-language.png?ezimgfmt=ng%3Awebp%2Fngcb8%2Frs%3Adevice%2Frscb8-1)
