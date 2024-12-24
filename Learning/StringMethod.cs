namespace Learning
{
    class StringMethod
    {
        static void Main(string[] args)
        {
            string str = "This is a string";

            int lenght = str.Length;
            Console.WriteLine(lenght);

            string upper = str.ToUpper();
            Console.WriteLine(upper);

            string lower = str.ToLower();
            Console.WriteLine(lower);

            string replace = str.Replace('s', '5');
            Console.WriteLine(replace);

            string insert = str.Insert(0, "Hy, ");
            Console.WriteLine(insert);

            int index = str.IndexOf('s');
            Console.WriteLine(index);

            int lastIndex = str.LastIndexOf('s');
            Console.WriteLine(lastIndex);

            bool endsWith = str.EndsWith("string");
            Console.WriteLine(endsWith);

            bool startsWith = str.StartsWith("the");
            Console.WriteLine(startsWith);

            bool Equal = str.Equals("This is a string");
            Console.WriteLine(Equal);

            bool Contains = str.Contains('i');
            Console.WriteLine(Contains);

            string trim = str.Trim();
            Console.WriteLine(trim);

            string subtrim = str.Substring(4, 4);
            Console.WriteLine(subtrim);

            string[] split = str.Split(' ');
            //Console.WriteLine(split);

            foreach (string s in split)
            {
                Console.WriteLine(s);
            }

        }
    }
}