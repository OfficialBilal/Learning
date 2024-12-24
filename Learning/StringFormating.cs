namespace Learning
{
    class StringFormating
    {
        static void Main(string[] args)
        {
            int age = 26;
            string name = "Bilal";
            decimal price = 12090.3563452m;

            string str = string.Format("Hi, {0} you are {1} years old", name, age);
            string pricee = string.Format("Total Price: {0:c}", price);

            Console.WriteLine(str);
            Console.WriteLine(pricee);

            //String Interpolation
            int agee = 26;
            string st = $"your age is {agee}";

            Console.WriteLine($"{st} and you are from Pakistan");

            Console.WriteLine(@"C:\Program Files");
            Console.WriteLine(@"C:\Program Files");
       
        }
    }
}
