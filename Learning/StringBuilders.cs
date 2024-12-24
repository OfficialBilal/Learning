using System.Text;

namespace Learning
{
    class StringBuilders
    {
        public static void Main(string[] args)
        {
            StringBuilder dstr = new ("This is a Strong");

            dstr.Append(" message");
            dstr.Append(" .");

            dstr.AppendFormat("this is append format");
            dstr.AppendLine("Append Line");
            dstr.Clear();

            Console.WriteLine(dstr); 

            Console.WriteLine($"Length: {dstr.Length}");
            Console.WriteLine($"Capacity:{dstr.Capacity}");
        }
    }
}
