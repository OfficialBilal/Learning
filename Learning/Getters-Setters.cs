using System;

namespace Learning
{
    class Getters_Setters
    {
        static void Main(string[] args)
        {
            Person1 person = new Person1();

            person.Name = "Bilal";
            person.Age = 18;

            Console.WriteLine($"Name: {person.Name}");

            

        }
    }
    class Person1
    {
        private string name = string.Empty;
        private int age = 19;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 18)
                { 
                    Console.WriteLine("You must be 18 Year old to Vote");
                return;
                }
                age = value;
            }
        }
    }
}
